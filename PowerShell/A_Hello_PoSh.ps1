$env:USERPROFILE

Get-ChildItem $env:USERPROFILE -Recurse -Filter *.url
# dir $env:USERPROFILE -r -fi *.url  - is the same!

"=============================================="
Get-Location  # gl & pwd - are aliases

"=============================================="
Get-Help about_*
Get-Help -Category provider
Get-Command ri # del == Remove-Item

Get-Procces  -?
Get-Process | Group-Object Company
# investigate object :
Get-Process | Get-Member [-MemberType Property]
Get-Process | Select-Object ProcessName, Id | Get-Member
# sorting by :
Get-Process | Sort-Object cpu -Descending
# select 5 highest memory usage processes :
Get-Process | Sort-Object WS | Select-Object -Last 5

"=============================================="
# PS-Drives (different types) :
Get-PSDrive

New-PSDrive -Name Docs -PSProvider FileSystem -Root 'C:\Documents and Settings\Public\Documents'
Set-Location Docs # cd ...

Set-Location HKLM:\Software

"=============================================="
$MaximumHistoryCount # 64
# $MaximumHistoryCount=100
Get-History | Where-Object {$_.CommandLine -like "*Get-*"} | Export-Csv ExportedHistory.csv
# next work time :
Import-Csv ExportedHistory.csv | Add-History

"=============================================="
# Execution Logging :
Start-Transcript -Path transcript.txt 
Get-Help Get-Process 
Stop-Transcript 
type transcript.txt #type == Get-Content
