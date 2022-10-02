#!/bin/bash
opc=10 
year=$(date +%Y-%m-%d)

function menu(){
clear
echo "Administrador de servidor"
echo "1)Ver cfg de la red"
echo "2)Editar cfg de red"
echo "3)Ver direccion de red"
echo "4)Asignar direccion de red"
echo "5)Eliminar direccion de red"
echo "6)Cambiar gateway"
echo "7)Estadisticas de la red"
echo "8)Usuarios conectados"
echo "9)Expulsar usuarios"
echo "0)Salir"

}

function vercfgred(){
clear
echo "Configuracion:"
ip route show
}
function edit_cfg(){
clear
ls -l /etc/NetworkManager/system-connections/
echo "escriba el nombre del archivo"
read -p "Nombre: " archivo
echo $archivo; read a
if [ -f /etc/NetworkManager/system-connections/$archivo  ]; then
	vim /etc/NetworkManager/system-connections/$archivo
else
	echo "el archivo no existe"
fi

}

function ver_ip(){
clear
echo "3"
}
function asign_ip(){
clear
echo "4"
}
function eliminar_ip(){
clear
echo "5"
}
function gateway(){
clear
echo "6" 
}
function estadistica_red(){
clear 
echo "7" 
}
function usuarios_conectados(){
clear
echo "8"
}
function usuario_kick(){
clear
echo "9"
}


while [ $opc -ne 0 ]
do
	clear
	menu
	read -p "Ingrese la opción correspondiente: " opc
	case $opc in
	1)
		vercfgred;
		read -p "presione enter para continuar" a ;;
	2)
		edit_cfg;
		read -p "presione enter para continuar" a;;
	3)
		ver_ip;
		read -p "presione enter para continuar" a;;

	4)
		asign_ip;
		read -p "presione enter para continuar" a;;
	5)
		eliminar_ip;
		read -p "presione enter para continuar" a;;
	6)
		gateway;
		read -p "presione enter para continuar" a;;
	7)
		estadistica_red;
		read -p "presione enter para continuar" a;;

	8)	usuarios_conectados;
	        read -p "presione enter para continuar" a;;

	9)	usuario_kick;
		read -p "presione enter para continuar" a;;

	0)	echo "Volviendo al menú principal";
	       	break ;; 

	*)	echo "OPCION INCORRECTA MALDITO";;
	esac
done
