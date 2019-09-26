# Calculate total dir size :
$TotalLength = 0
dir | ForEach-Object {$TotalLength += $_.Length}
$TotalLength

"==============================================="

dir | Measure-Object -Property Length -Sum -Maximum -Minimum -Average

"==============================================="

(Get-Date "09.11.1974").DayOfWeek  # Saturday 

[System.Math]::Sqrt(169)  # 13

[System.Math] | Get-Member -Static