# GTAutofarmer

A multi-account autofarmer bot for Growtopia.

## How to use

GTAutofarmer only works on Windows.
GTAutofarmer can open multiple instances of Growtopia at the same time and farm with them.
You can download a .exe file and launch it to start using it right away, or compile it from source.
GTAutoFarmer `kernel32.dll` and `ntdll.dll`.

## Common problems

### It doesn't punch or does it in a wrong place!

1. Make sure you have touch controls on.
2. Make sure your inventory is not opened, the punch button should be in the screen corner.
3. Make sure that you keep your screen size as default, no fullscreen.

### It doesn't place or does it in a wrong place!

1. First read the previous section "It doesn't punch or does it in a wrong place!"
2. Make sure that your chatbox shows just a single row of text.
3. Make sure that the amount of hits isn't too low; you can try setting it even higher than the actual amount of hits it takes.
4. If nothing else works, open an issue. Or you may try changing how often the timer(s) run in the code and compile it yourself.

### I can't open multiple Growtopia windows!

1. If it says "Not Responding", then your PC can't handle so many Growtopia windows opening one after another. Try opening them in smaller amounts.
2. If it doesn't allow opening multiple Growtopia windows at all ("Did you unzip everything right?"), then make sure you opened this program as an administrator.
3. If absolutely nothing works, you can open the windows by yourself. This program will detect already opened Growtopia instances when it launches. For that you can use [Process Hacker](https://github.com/processhacker/processhacker) or [Process Explorer](https://docs.microsoft.com/en-us/sysinternals/downloads/process-explorer). You can get an idea on how to do it manually by reading the "How it works" page or watching a YouTube tutorial.

### I got an error or another issue!

Open an issue (or contact me personally via email, YouTube, or Discord) and give as many details as you can. Keep in mind that this software has not been tested on a 32-bit system.

## Media

![Media 1](https://i.imgur.com/0EBYzzL.gif)

![Media 2](https://i.imgur.com/MEk6s9u.gif)

![Media 3](https://i.imgur.com/F2BlVzH.png)

![Media 4](https://i.imgur.com/FO3n7xc.png)

###### (may be outdated)

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
