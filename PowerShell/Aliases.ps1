
Set-Alias npp "C:\Program Files\Notepad++\notepad++.exe"
npp

Set-Alias -Name zlist -Value Get-ChildItem
zlist # using
Remove-Item alias:zlist


"=============================================="
# simple function
function MyFunc1($a) {"Hello, $a!"}
MyFunc1 Alex Murhpy  #> Murphy - will ignored - use quotes!

# create func
Function CD32 {Set-Location c:\windows\system32} 

# set alias to func
Set-Alias go cd32

# export own aliases to file
Export-Alias .\Aliases_Exported.txt

# remove alias
Remove-Item alias:go