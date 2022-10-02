#!/bin/bash
opc=10 
fecha=$(date +%Y %m %d)

function menu(){
echo "Menu administrativo"
echo "1)Menu Usuarios"
echo "2)Menu Red"
echo "3)Gestor BD"
echo "4)Respaldo Logs"
echo "0)Salir"
}
#la idea es tener una carpeta oculta en el directorio personal de los
#administradores con este script
function user(){
if [ $user -eq "Administrador" ]; then

./home/$user/.scriptsadmin/menuusuarios.sh

else

echo "Usuario no autorizado"
echo "$fecha, se intento entrar al script sin autorizacion" >> /var/log/logCusuarios.txt

fi
}
function red(){
if [ $user -eq "Administrador" ]; then

./home/$user/.scriptsadmin/menured.sh

else

echo "Usuario no autorizado"
echo "$fecha, se intento entrar al script sin autorizacion" >> /var/log/logCusuarios.txt

fi
}
function bd(){
	if [ $user -eq "Administrador" ]; then

./home/$user/.scriptsadmin/gestorbd.sh

else

echo "Usuario no autorizado"
echo "$fecha, se intento entrar al script sin autorizacion" >> /var/log/logCusuarios.txt

fi

}
function logs(){
if [ $user -eq "Administrador" ]; then

./home/$user/.scriptsadmin/RespaldoScript.sh

else

echo "Usuario no autorizado"
echo "$fecha, se intento entrar al script sin autorizacion" >> /var/log/logCusuarios.txt

fi
}


while [ $opc -ne 0 ] do 
clear
menu
case $opc in
	1) user;
		read -p "presione una tecla para continuar" a;;
	2) red;
		read -p "presione una tecla para continuar" a;;
	3) bd;
		read -p "presione una tecla para continuar" a;;
	4) logs;
		read -p "presione una tecla para continuar" a;;
	0)echo "Saliendo del programa"
		break;;
	*) echo "opcion no valida"
		;;
esac
done 





esac
done
