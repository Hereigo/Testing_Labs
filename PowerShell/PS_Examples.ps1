# GET INFO IN FORMAT-LIST ( * - All properties ) :
Get-Service | Where-Object {$_.Name -eq "LSM"} | Format-List *

# Name                : LSM
# RequiredServices    : {DcomLaunch, RpcSs, RpcEptMapper}
# CanPauseAndContinue : False
# CanShutdown         : False
# CanStop             : False
# DisplayName         : Local Session Manager
# DependentServices   : {}
# MachineName         : .
# ServiceName         : LSM
# ServicesDependedOn  : {DcomLaunch, RpcSs, RpcEptMapper}
# ServiceHandle       : 
# Status              : Running
# ServiceType         : Win32OwnProcess, Win32ShareProcess
# StartType           : Automatic
# Site                : 
# Container           : 


# OUTPUT SOURCES :
Get-Command out-* | Format-Table Name
# Out-Default
# Out-File
# Out-Host
# Out-Null  -  Do not output/ do not show output.
# Out-Printer
# Out-String
Get-Help Get-Process –Full | Out-Host –Paging