# AR Vuforia
Para integrar AR con Vuforia en tu proyecto Unity, sigue estos pasos:


## Licencia Vuforia:

Crea una licencia en Vuforia Engine y agrégala a tu proyecto Unity.
Configuración para Android:
![image](https://github.com/Ariel454/AR_Vuforia/assets/121766763/460d16e4-7869-445f-a06c-95679cc655d4)


Asegúrate de configurar tu proyecto Unity para Android.
![image](https://github.com/Ariel454/AR_Vuforia/assets/121766763/79c6a241-abc6-4458-8c93-18c3e0508a43)
## SDK de Vuforia:

Agrega el paquete SDK de Vuforia para Unity a tu proyecto.
![image](https://github.com/Ariel454/AR_Vuforia/assets/121766763/dc94bc8b-03cf-4d77-8c69-d7e01889d937)

## AR Camera:

Agrega un componente AR Camera y configúralo con la licencia de Vuforia.
![image](https://github.com/Ariel454/AR_Vuforia/assets/121766763/59be63be-26a3-4dd3-850f-16a5c59a4971)

## Image Target:

Agrega un Image Target y asigna la imagen en la sección de comportamiento.
![image](https://github.com/Ariel454/AR_Vuforia/assets/121766763/622d145d-558f-4a10-97bc-6441d207c749)

## Prefabs:

Coloca tus prefabs dentro del Image Target para controlar su aparición.
![image](https://github.com/Ariel454/AR_Vuforia/assets/121766763/21515e03-5f84-47e6-9453-bcc4a4526c14)

## Scripts de Movimiento:

Añade un script de movimiento a los objetos que lo necesiten.
![image](https://github.com/Ariel454/AR_Vuforia/assets/121766763/5fc8982c-303f-45af-a1d9-bf3143befbae)

## Script de Movimiento
![image](https://github.com/Ariel454/AR_Vuforia/assets/121766763/d35541a5-82aa-4c26-ace5-c3e74a743cf9)

Campo Privado:

rb: Un campo privado que almacena una referencia al componente Rigidbody del objeto.
Método Start:

Inicializa el campo rb obteniendo una referencia al componente Rigidbody.
Método Update:

Obtiene la entrada del teclado para las teclas horizontales y verticales.
Crea un vector de movimiento utilizando los valores de entrada.
Asigna la velocidad al objeto multiplicando el vector de movimiento por un factor de velocidad.
Método OnTriggerEnter:

Se llama cuando el objeto con el script entra en colisión con otro objeto.
Imprime un mensaje en la consola indicando la colisión.
Verifica si el objeto colisionado tiene el tag "Esfera" y, si es así, destruye el objeto.
