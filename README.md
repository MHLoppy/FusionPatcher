# Fusion Patcher

A patcher for Rise of Nations: Extended Edition which allows reassignment of 
up to three nation powers for each nation. I've been kicking around something 
along these lines since about 2019, but Chinese modder Stack Pointer had a 
variant of the same idea which they had applied to Thrones & Patriots and they 
asked me to port it to the Extended Edition. This was the result!

It's a quick-and-dirty implementation i.e., ugly, mostly unoptimized, and with 
very limited error handling. It's also my first time using the ancient 
WinForms library/framework, so I don't even know what I'm doing.

![](RoN-fusion-screenshot-01.png)

The patching itself occurs in two parts:
- A copy of the game exe is made, and a "pre-patch" is applied to the copy 
that adds some handwritten assembly to the game exe. This assembly has been 
explicitly designed to make programmatic patching relatively straightforward.
- Since the pre-patched exe has a known structure, write locations can be 
dynamically calculated, with the bytes to write translated from UI entries.

For the sake of completeness the main block of assembly is included in this 
repo, but the intended method of distribution is via [Steam Workshop](https://steamcommunity.com/sharedfiles/filedetails/?id=3604787417), 
which includes the bsdiff patch files required to do the pre-patching.

## Credits

- Relies on the [BsDiff library](https://github.com/Faithlife/bsdiff.net).

## License

Code and documentation are licensed under Big Bill Hell's License (BBHL). 
An audio copy of the license is included.
