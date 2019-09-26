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