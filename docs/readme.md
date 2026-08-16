#to run code ```
 dotnet run main.cs ```


#To start the agent ```
Get-Service -Name ssh-agent | Set-Service -StartupType Manual
Start-Service ssh-agent
Get-Service ssh-agent ```


# add key to ssh agent 
``` ssh-add C:/Users/Madhumithabalu/.ssh/id_ed25519```
