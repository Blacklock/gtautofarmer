# GTAutofarmer

A multi-account autofarmer bot for Growtopia.

## How to use

GTAutofarmer can open multiple instances of Growtopia at the same time and farm with them.
You can download a .exe file and launch it to start using it right away, or compile it from source.
GTAutoFarmer `kernel32.dll` and `ntdll.dll`.

## Common problems

### It doesn't punch or does it in a wrong place!

1. Make sure you have touch controls on.
2. Make sure your inventory is not opened, the punch button should be in the screen corner.
3. Make sure that you keep your screen size as default, no fullscreen.

### I got an error!

Open an issue and give as many details as you can. This software has not been tested on a 32-bit system.

## How it works

Growtopia and many other games only allow one instance of the game running at a time and check it with a mutant handle. 
Growtopia checks if any mutant handles with the name `\Sessions\1\BaseNamedObjects\Growtopia` exist.
So we have to delete them. But if the game is running and no mutant handles with that name exist, then the game crashes.
Due to that we have to suspend (freeze) all the Growtopia instances while there's no mutant handles.

### Details

When a new instance of Growtopia.exe launches, we first suspend all the other instances of the game using `SuspendThread`.
Then we get all the handles in the system with `NtQuerySystemInformation` and filter out those that are not from the latest
Growtopia opened (the only one with these mutant handles). We get the names of the remaining handles by first duplicating 
them with `DuplicateHandle` so that we can retrieve information out of them with `NtQueryObject`. We filter out handles 
with incorrect names and end up with handles we have to delete. To close the handles, we use `DuplicateHandle` with 
`DUPLICATE_CLOSE_SOURCE` and specify no process to duplicate to.

Once all the mutant handles are deleted, we launch a new Growtopia.exe that creates them. Now we resume all the other
Growtopia.exe's with `ResumeThread` and we've ended up with one more Growtopia instance open. If the user specified
he wants to open multiple, we won't resume any Growtopia.exe's till the very end.

## Authors

* **Just Another Channel** - *Author* - [YouTube](https://youtube.com/c/justanotherchannels)

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details
