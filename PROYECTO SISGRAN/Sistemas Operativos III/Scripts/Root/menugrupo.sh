#!/bin/bash
opc=5
year= (date +%Y-%m-%d)
function menu(){
	echo "1) Agregar nuevo grupo" 
	echo "2) Borrar grupo"
	echo "3) Listar grupos"
	echo "0) Salir"


}
function addgroup(){
echo "ingrese nombre de grupo: "
read grupito
echo "ingrese guid de forma manual: "
read gid
grupouser=$(echo $grupito | tr [:upper:][:lower:])
grupoverificado=$(cat /etc/group | grep -c $grupouser)
gidv=(cat /etc/group | grep -c $gid)
if [ $grupoverificado -eq 1 | $gidv -eq 1 ]; then 
echo "ERROR, el grupo ya existe y la guid esta usada"
echo "$year, se intento agregar un grupo pero ya existe" >> /var/log/loggrupo.txt
else 
groupadd -g $gidv $grupoverificado

fi	
}
function delgroup(){
echo "ingrese el nombre del grupo: "
read groupdel
grupouser=$(echo $groupdel | tr [:upper:][:lower:])
grupoverificado=$(cat /etc/group | grep -c $groupdel)
if [ $grupoverificado -eq 1  ]; then

groupdel $grupoverificado
echo "$year, se borro el grupo $grupoverificado del sistema" >> /var/log/loggrupo.txt

else

	echo "Error, el grupo no existe"
	echo "$year, se intento agregar un grupo pero no existe" >> /var/log/loggrupo.txt

fi


}
function listgroup(){
echo "Lista de grupos: " 
cut -d ":" -f 1 /etc/group
}
while [ $opc -ne 0 ] do
clear
menu
case $opc in 

	1) addgroup;
		echo "presione una tecla para continuar";;

	2) delgroup;
		echo "presione una tecla para continuar";;

	3) listgroup;
		echo "presione una tecla para continuar";;
	0) echo "Saliendo del programa";
			break;;
	*) echo "opcion no valida";; 

esac
done	
