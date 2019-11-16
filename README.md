# GTAutofarmer

A multi-account autofarmer bot for Growtopia. This project has been abandoned as of now. The multiboxing branch was a complete disaster when I last touched it, and there were some issues with autofarming as well.

## How to use

GTAutofarmer only works on Windows.
GTAutofarmer can open multiple instances of Growtopia at the same time and farm with them.
You can download a .exe file and launch it to start using it right away, or compile it from source.
GTAutoFarmer uses `kernel32.dll` and `ntdll.dll`.

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
3. If absolutely nothing works, you can open the windows by yourself. This program will detect already opened Growtopia instances when it launches. For that you can use [Process Hacker](https://github.com/processhacker/processhacker) or [Process Explorer](https://docs.microsoft.com/en-us/sysinternals/downloads/process-explorer).

## Media

![Media 1](https://i.imgur.com/0EBYzzL.gif)

![Media 2](https://i.imgur.com/MEk6s9u.gif)

![Media 3](https://i.imgur.com/F2BlVzH.png)

## How it works

Growtopia uses a mutant handle called `\Sessions\1\BaseNamedObjects\Growtopia` which prevents us from opening more than one instance of the game at a time. To circumvent that, we first suspend all the instances of the game (since it'll crash if we just attempt to delete the handles), and only then delete the handles and open a new game.

### Details

When a new instance of Growtopia.exe is launched, we first suspend all other instances of the game using `SuspendThread`.
Then we get all the handles in the system with `NtQuerySystemInformation` and filter out those that are not owned by the latest Growtopia process). We get the names of the remaining handles by duplicating them with `DuplicateHandle` so that we can retrieve information out of them with `NtQueryObject`. 

Then we filter out handles with incorrect names and end up with the handles that we have to delete. 
To do that, we use `DuplicateHandle` with `DUPLICATE_CLOSE_SOURCE` and specify no process to duplicate to.

Once all the handles are deleted, we launch a new Growtopia process, which will create new handles. Now we resume all the other
Growtopia.exe's with `ResumeThread` and we've ended up with one new Growtopia instance open.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
