
# '-Filter' is much faster than 'Where-Object'. But not all commands offer the possibility to filter.

# Equal :
Get-Service | Where-Object {$_.Status -eq "Stopped"}

# Like : (-contains)
Get-ChildItem -Path $env:USERPROFILE | Where-Object {$_.Name -like 'D*'}
# Desktop, Documents, Downloads

# GreaterThan & LessThan :
Get-Process | Where-Object {($_.Id -gt 100) -and ($_.Id -lt 200)}

# For Windows Servers only.
# Get-WindowsFeature | Where-Object {$_.InstalState -Eq "Installed"}