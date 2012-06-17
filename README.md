inotify-win
===========
A port of the inotify-wait tool for Windows, see http://linux.die.net/man/1/inotifywait

Compiling
=========
Run `make` in this directory. This will create the executable, `inotify-wait.exe`.

Usage
=====
The command line arguments are similar to the original one's:

```sh
$ ./inotify-wait.exe
Usage: inotify-wait [options] path

Options:
-r/--recursive:  Recursively watch all files and subdirectories inside path
-m/--monitor:    Keep running until killed (e.g. via Ctrl+C)
-q/--quiet:      Do not output information about actions
-e/--event list: Which events (create, modify, delete, move) to watch, comma-separated. Default: all
--format format: Format string for output.

Formats:
%e             : Event name
%f             : File name
%w             : Path name
%T             : Current date and time
```
