$MyVariable
Test-Path Variable:MyVariable # False - Undefined!

# To see all current session Variables :
dir Variable:

# Calculate total dir size :
$TotalLength = 0
dir | ForEach-Object {$TotalLength += $_.Length}
$TotalLength

# or
dir | Measure-Object -Property Length -Sum -Maximum -Minimum -Average

"==============================================="

(Get-Date "09.11.1974").DayOfWeek  # Saturday 

[System.Math]::Sqrt(169)  # 13

[System.Math] | Get-Member -Static

"String with ""quotted words""."

"`$symbol - Screened variable is just a text."

"This text is divided into `n two lines!"

$multilinetext=@"
1st line text
$(1+1) - Second line
"Line # 3"
"@;
$multilinetext
