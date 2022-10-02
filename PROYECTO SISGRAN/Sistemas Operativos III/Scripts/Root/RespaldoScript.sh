#!/bin/bash
fecha=$(date +%Y-%m-%d-%H-%M-%S)
 
if [ -d /home/$user ]; then

	mkdir -p /home/$user/.respaldo/$fecha
	cp -r  /var/log/maillog* /home/$user/.respaldo/$fecha
	cp -r /var/log/messages* /home/$user/.respaldo/$fecha
	cp -r /var/log/secure* /home/$user/.respaldo/$fecha
	cp -r /var/log/cron* /home/$user/.respaldo/$fecha	
	cp -r /var/log/httpd* /home/$user/.respaldo/$fecha 
	cp -r /var/log/spooler* /home/$user/.respaldo/$fecha
	cp -r /var/log/utmp* /home/$user/.respaldo/$fecha
	cp -r /var/log/wtmp* /home/$user/.respaldo/$fecha 
else
	clear
	echo "el directorio no existe"
	sleep 5

fi
