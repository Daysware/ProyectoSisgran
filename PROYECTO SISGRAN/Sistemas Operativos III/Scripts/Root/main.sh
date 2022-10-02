#!/bin/bash
opc=10
fecha=$(date +%Y-%m-%d)


function menu(){
echo "Menu Inicial"
echo "1) Menu de usuarios "
echo "2) Menu de grupos "
echo "3) Menu de red "
echo "4) Respaldo "
echo "0) Salir "
}

function menuuser(){
bash ./root/scripts/menuusuarios.sh
}

function menugrupo(){
bash ./root/scripts/menugrupo.sh
}

function menured(){
bash ./root/scripts/menured.sh
}

function respaldo(){
bash ./root/scripts/RespaldoScript.sh
}

while [ $opc -ne 0 ] do 
clear 
menu
case $opc in
	1)menuuser;
	   read -p "presione una tecla para continuar"a;; 
	2)menugrupo;
		read -p "presione una tecla para continuar"a;;
	3)menured;
		read -p "presione una tecla para continuar"a;; 
	4)respaldo;
		read -p "presione una tecla para continuar"a;; 
	0)exit
	break;;
	*)echo "opcion no valida"
		;;
esac
done
