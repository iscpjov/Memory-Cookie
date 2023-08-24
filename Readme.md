#Memory In Cache

## Acerca de 
un proyecto de muestra donde se crea un libreria para poder guardar datos permanentemente de una forma muy facil y rapida


###Datos permitidos
- variables nativas (int, double, bolean etc etc)
- array y list
- objetos
 

## Descarga 
[InCookie](https://drive.google.com/drive/folders/15rXIj2iQcYYMOiNvEnzBbaB2tpbLYuBA?usp=drive_link)

##Instalacion
agregar a un biblitecla de clases el dll 
cargar dependencias
using InCache.Cookie


###Documentacion

#### guardado y modificiacion
Cookie.Set(Key, Value) 
Key es un dato string para identificar la cookie
Value es cualquier elemento a guardar
return un dato bolean
**Ejemplo** int x = Cookie.Set("x", 20)

#### recuperar datos almacenados
Cookie.Get(key) 
Key es un dato string para identificar la cookie
return el valor si este existe, de caso contrario devuelve null (tambien si exitio un problema para su recuperacion)
**Ejemplo** 
int x = Cookie.Get("x")

#### recuperar datos almacenados o guardado
Cookie.Get(Key, Value)
Key es un dato string para identificar la cookie
Value es cualquier elemento a guardar
returna si la cookie existe returna el valor, si no existe returna el nuevo valor y lo almacena
**Ejemplo** 
int x = Cookie.Get("x", 20)

#### recuperar datos con tipo almacenados 
Cookie.Get`<T>` (key) 
T ddato generico 
Key es un dato string para identificar la cookie
return el valor si este existe, de caso contrario devuelve null (tambien si exitio un problema para su recuperacion)
**Ejemplo** 
int x = Cookie.Get`<T>`("x")

#### recuperar datos con tipo almacenados o guardado
Cookie.Get`<T>`(Key, Value)
T ddato generico 
Key es un dato string para identificar la cookie
Value es cualquier elemento a guardar
returna si la cookie existe returna el valor, si no existe returna el nuevo valor y lo almacena
**Ejemplo** 
int x = Cookie.Get`<T>`("x", 20)

#### existencia
Cookie.ContainsKey(Key)
Key es un dato string para identificar la cookie
returna true si existe, caso contrario false
**Ejemplo** 
bool existX = Cookie.ContainsKey("x")    
--- o ---
if(Cookie.ContainsKey("x"))
{
	int x = Cookie.Get("x")
}

#### conocer el tipo de la cookie(texto)
Cookie.GetStringType(key)
Key es un dato string para identificar la cookie
return una cadena de texto con el type si se encontro la cookie si no regrega nada
**Ejemplo** 
string txtType = Cookie.GetStringType("x")

#### conocer el tipo de la cookie(type)
Cookie.GetType(key)
Key es un dato string para identificar la cookie
return un Type de la cookie almacenada si no se contro es null
**Ejemplo** 
Type type = Cookie.GetType("x")

#### borrar cookie
Cookie.Remove(key)
Key es un dato string para identificar la cookie
return true si la cookie false si no se pudo eleminar
**Ejemplo** 
bool ifRemove = Cookie.Remove("x")

#### limpiar las cookies
Cookie.Clear()
Key es un dato string para identificar la cookie
return true si la cookie false si no se pudo eleminar
**Ejemplo** 
Type type = Cookie.Clear()



