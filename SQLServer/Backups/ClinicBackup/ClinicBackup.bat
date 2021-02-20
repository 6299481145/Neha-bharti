set dd = %date:~0,2%
set mm = %date:~3,2%
set yyyy= %date:~6,4%
set filename = Backup_%yyyy%%mm%%dd%.sql
echo %clinicBackup%
sqlcmd -S(localdb)\mssqllocaldb -Q "Backup Database clinic To Disk ='D:\Neha Bharti\SQLServer\Backups\ClinicBackup\echo %ClinicBackup%.bak'"