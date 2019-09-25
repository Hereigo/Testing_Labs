"=============================================="
(Get-Date "09.11.1974").DayOfWeek  # Saturday 

"=============================================="
[System.Math]::Sqrt(169)  # 13

"=============================================="
$var=10/2
$var  # 5

"=============================================="
$env:USERPROFILE

Get-ChildItem $env:USERPROFILE -Recurse -Filter *.url
# dir $env:USERPROFILE -r -fi *.url  - is the same!

"=============================================="
Get-Location  # gl & pwd - are aliases

"=============================================="
Get-Help about_*
Get-Help -Category provider
Get-Procces  -?
Get-Command ri # del == Remove-Item
# investigate object :
Get-Process | Get-Member [-MemberType Property]

"=============================================="
# PS-Drives :
Get-PSDrive

New-PSDrive -Name Docs -PSProvider FileSystem -Root 'C:\Documents and Settings\Public\Documents'
Set-Location Docs # cd ...

Set-Location HKLM:\Software

"=============================================="
$MaximumHistoryCount # 64
# $MaximumHistoryCount=100

"=============================================="
Get-History | Where-Object {$_.CommandLine -like "*Get-*"} | Export-Csv ExportedHistory.csv
# next work time :
Import-Csv ExportedHistory.csv | Add-History

"=============================================="
# Execution Logging :
Start-Transcript -Path transcript.txt 
Get-Help Get-Process 
Stop-Transcript 
type transcript.txt #type == Get-Content
