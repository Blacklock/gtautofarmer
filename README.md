# GTAutofarmer (abandoned)

**This project is unfinished & has been abandoned. There are better autofarmers out there nowadays, go use one of those instead. It is also apparently now detectable by the anticheat.**

## Media

![Media 1](https://i.imgur.com/0EBYzzL.gif)

![Media 2](https://i.imgur.com/MEk6s9u.gif)

![Media 3](https://i.imgur.com/F2BlVzH.png)

## How it ~~works~~ worked

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
