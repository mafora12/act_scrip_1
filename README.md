## Descripción general  
En esta serie de ejercicios se desarrollaron diferentes programas en C# enfocados en reforzar la lógica de programación y la Programación Orientada a Objetos. 
Se trabajaron funciones, clases, herencia, métodos abstractos y virtuales, sin utilizar librerías avanzadas cuando el enunciado lo pedía.  

## Ejercicios realizados  

### 1. Números primos en la serie de Fibonacci
Se creó un programa que genera la serie de Fibonacci hasta un número n y muestra únicamente los términos que son números primos. Para esto se implementó una función que verifica si un número es primo y otra que genera la serie.  

### 2️. Conversión de segundos a formato HH:MM:SS  
Se implementó una función que recibe una cantidad de segundos y los convierte al formato HH:MM:SS, usando solo operaciones matemáticas y sin utilizar la clase DateTime.  

### 3. Juego de chance  
Se desarrolló una función que compara un número apostado de 4 dígitos con el número ganador y determina si el jugador obtiene un premio. El cálculo del premio se hace según las reglas dadas (orden, desorden y coincidencia de cifras). Si no hay premio, la función retorna 0.  

### 4. Manejo de mensajes con clases abstractas    
Se creó una clase abstracta llamada AbstractSample con un atributo privado, un método abstracto y un método virtual para invertir mensajes.
A partir de esta clase se implementaron dos subclases:  

- una que imprime el mensaje normalmente  
- otra que imprime el mensaje con mayúsculas y minúsculas invertidas y sobrescribe el método de inversión  

### 5. MessageManager  
Se implementó una clase MessageManager que instancia dos objetos de tipo AbstractSample y llama a sus métodos PrintMessage, aplicando polimorfismo para ejecutar diferentes comportamientos con la misma referencia.  

## Conceptos aplicados  

- Funciones y estructuras básicas  
- Manejo de strings  
- Condicionales y ciclos  
- Encapsulación  
- Herencia
- Métodos abstractos y virtuales
- Sobrescritura de métodos  
- Polimorfismo

## Conclusión
Estos ejercicios permitieron reforzar la lógica de programación en C# y comprender mejor el uso de la Programación Orientada a Objetos, aplicando soluciones claras y acordes al nivel de aprendizaje.
