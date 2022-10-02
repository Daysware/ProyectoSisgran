#!/bin/bash
opc=8
year=$(date +%Y-%m-%d)


function menu(){
clear
echo "1)Agregar Usuarios"
echo "2)Eliminar Usuarios" 
echo "3)Listar Usuarios registrados"
echo "4)Buscar usuario"
echo "5)Cambiar clave de usuario"
echo "6)Bloquear Usuario"
echo "7)Desbloquear Usuario"
echo "0)Salir"
}

function adduser(){
echo "ingrese nombre del usuario"
read -p "nombre:  " nombre
usuario=$(echo $nombre | tr [:upper:] [:lower:])
nomb=$(cat /etc/passwd | grep -c $usuario)
if [ $nomb -eq 1 ]; then 
	echo "el usuario ya existe en el sistema"
	echo "$year Se intento agregar el usuario $usuario pero existe en /etc/passwd" >> /var/log/logUsuarios.txt
	

else
	echo "ingrese el nombre del grupo: "
	read grupo
	grupousuario=$(echo $grupo | tr [:upper:][:lower:])
	grup0=$(cat etc/group | grep -c $grupousuario)
	if [ $grup0 -eq 1 ]; then
		useradd -g $grupousuario -c "$grupousuario $year" -mk /etc/skel -s /bin/bash $usuario
		echo "$year se agrego el usuario $usuario que pertenece al grupo $grup0 del sistema" >> /var/log/logCusuarios.txt
		passwd -e -d $usuario
		echo "usuario dado de alta"

	else
		echo "no existe el grupo" 
		echo "$year se trato de agregar el grupo $grup0 pero el grupo ya existe" >> /var/log/logCusuarios.txt


	fi
fi
}
function deluser(){
	clear
	echo "ingrese el nombre del usuario a borrar"
	read usuariodel
	eusuario=$(cat etc/passwd | grep -c $usuariodel)
	if [ $usuariodel -eq 1 ]; then
		userdel -r $usuariodel 
		echo "$year se  borro el usuario $usuariodel que existia en el sistema" >> /var/log/logCusuarios.txt
	else
		echo "el usuario no existe"
		echo "$year se trato de borrar el usuario $usuariodel pero no existe en el sistema" >> /var/log/logCusuarios.txt
	fi
}
function listuser(){
	echo "Listado de Usuarios registrados:"
	cut -d ":" -f 1 /etc/passwd
}
function search(){
	clear
	read -p "ingrese el usuario a buscar: " nombre
	
	eusuario=$(cat etc/passwd | grep -c $nombre)
	if [ $eusuario -eq 1  ]; then 
		echo "El usuario ya existe" 
		nomb=$(cut -d ":" -f 1 /etc/passwd | grep $nombre)
	

	fi
}
function change(){
clear 
read -p "Ingrese usuario registrado: " nombre
eusuario=$(cat /etc/passwd | grep -c $nombre)
if [ $eusuario -eq 1 ]; then
	passwd $eusuario
	echo "$year se cambio la contraseña del usuario $eusuario en el sistema" >> /var/log/logCusuarios.txt
else 
	echo "El usuario no existe"
	echo "$year se intento cambiar la contraseña del usuario $eusuario pero no existe en el sistema" >> /var/log/logCusuarios.txt
fi	
}
function bloqueo(){
clear 
echo "ingrese el nombre del usuario a bloquear: "
read nombre
usuario=$(echo $nombre | tr [:upper:] [:lower:])
if [ $usuario -eq 1 ];then
	usermod -l $usuario
	echo "usuario bloqueado"
	echo "$year bloqueo el usuario  $usuario que pertenece al grupo $grup0 del sistema" >> /var/log/logCusuarios.txt

else
	echo "Error el usuario no existe"
	echo "$year se intento bloquear al usuario $usuario pero no existe en el sistema" >> /var/log/logCusuarios.txt
fi
}
function desbloq(){
clear 
read -p  "ingrese nombre de usuario: " nombre
eusuario=$(cat /etc/passwd | grep -c $nombre)
if [ $eusuario -eq 1 ]; then
       usermod --unlock $eusuario
       echo "usuario desbloqueado"
	echo "$year se desbloqueo  el usuario $eusuario en el sistema" >> /var/log/logCusuarios.txt
else 
	echo "usuario no existente"
	echo "$year se intento desbloquear  al usuario $usuario pero no existe en el sistema" >> /var/log/logCusuarios.txt
fi	
}



while [ $opc -ne 0 ]
do
clear
menu
read -p "Digite una opcion" opc
case $opc in 
	1) adduser;
		read -p "presione una tecla para continuar" a;;
	2) deluser;
	       read -p "presione una tecla para continuar" a;; 
        3) listuser; 
 		read -p "presione una tecla para continuar" a;; 
	4) search;
		read -p "presione una tecla para continuar" a;; 
	5) change; 
		read -p "presione una tecla para continuar" a;;
	6) bloqueo;
		read -p "presione una tecla para continuar" a;; 
	7) desbloq;
		read -p "presione una tecla para continuar" a;;		
	0) echo "Saliendo del programa .......";
			break ;;
	*) echo "opcion incorrecta";;
esac
done
