# C-Sharp.Unity.Delegados-Eventos
Esta es la tercera práctica de la asignatura "Interfaces Inteligentes"

## Hitos Ejercicio 1 (Esferas, cubo y cilindro)
- Crear la escena con 5 esferas, un cubo y un cilindro, con  dos grupos identificables de esferas, las tipo 1 y tipo 2 (a través de tags).
- Configurar la colisión a través de OnTriggerEnter.
- Implementar el envío de un evento o mensaje desde el cilindro cuando el cubo colisione con él y suscribir las esferas al mensaje del cilindro (OnMiColision).
- Hacer que las esferas de tipo 1 se desplacen hacia una esfera de tipo 2 seleccionada previamente y que las esferas de tipo 2 se desplacen hacia el cilindro (MoveTowards).
<img width="1280" height="720" alt="Ejercicio1" src="https://github.com/user-attachments/assets/fbfd260c-1131-4b31-b455-e9e8936ac675" />

## Hitos Ejercicio 2 (Sustituir esferas por humanoides)
- Importar los dos modelos de humanoides de la Asset Store.
- Sustituir las esferas por los modelos 3D.
- Adaptar los scripts de movimiento y detección de colisiones a los nuevos modelos.
- Comprobar que los humanoides se desplazan hacia los mismos destinos que las esferas.
<img width="1280" height="720" alt="Ejercicio2" src="https://github.com/user-attachments/assets/ea39a51c-eac7-4ee3-9637-8ef38c2be79c" />

## Hitos Ejercicio 3 (Humanoides y escudos)
- Crear los grupos de humanoides y escudos de tipo 1 y tipo 2.
- Configurar los Colliders y Rigidbodys de los humanoides de tipo 1 y el escudo prefijado (tipo 1) y de los escudos de tipo 2.
- Detectar la colisión del cubo con cualquier humanoide de tipo 2 y tipo 1.
- Al producirse una colisión, hacer que los humanoides del grupo 1 se dirijan a los escudos pertinentes.
- Cambiar el color del humanoide cuando colisione con uno de los escudos del tipo 2.
  <img width="1280" height="720" alt="Ejercicio3" src="https://github.com/user-attachments/assets/3e7fc9d8-44bf-4705-a4ee-a0222ce35296" />

## Hitos Ejercicio 4 (Teletransporte y orientación)
- Crear un objeto de referencia que el cubo pueda alcanzar o al que pueda aproximarse y configurar la detección de esta referencia hacia el cubo.
- Seleccionar previamente el escudo objetivo y guardar su referencia.
- Teletransportar los humanoides del grupo 1 al escudo objetivo.
- Crear un objeto específico (esfera) hacia el que deban orientarse los humanoides del grupo 2.
- Hacer que los humanoides del grupo 2 miren hacia ese objeto.
<img width="1280" height="720" alt="Ejercicio4" src="https://github.com/user-attachments/assets/9a5a8988-e115-4e0e-befa-3084f570d55d" />

## Hitos Ejercicio 5 (Recolección de escudos y puntuación)
- Identificar cada escudo como tipo 1 o tipo 2 y detectamos su respectiva colisión frente al cubo.
- Sumamos 5 puntos al recoger un escudo de tipo 1 o sumamos 10 puntos si es de tipo 2.
- Mantener una puntuación acumulada en el jugador.
- Mostrar la puntuación actualizada mediante Debug.Log.
- Evitar que un mismo escudo otorgue puntos varias veces (Destroy).
<img width="1280" height="720" alt="Ejercicio5_2" src="https://github.com/user-attachments/assets/85f477b1-0716-4454-95a8-21e4005a9f45" />

## Hitos Ejercicio 6 (Interfaz de puntuación)
- Crear un Canvas para contener los elementos de la interfaz.
- Añadir un texto con TextMeshProUGUI.
- Mostrar la puntuación actual del jugador.
- Actualizar el texto de la interfaz cuando cambie la puntuación.
<img width="1280" height="720" alt="Ejercicio6_2" src="https://github.com/user-attachments/assets/6e2b1485-e820-4a7a-bd51-66e7925b62a5" />

## Hitos Ejercicio 7 (Recompensa cada 100 puntos)
- Definir la recompensa del jugador (un aumento temporal de velocidad).
- Detectar cuándo la puntuación alcanza o coincide con el patrón (n % 100 == 0).
- Activamos la recompensa (sumando una cantidad de velocidad).
- Mostrar un mensaje de recompensa en la interfaz.
- Mantener la recompensa durante el tiempo establecido (WaitForSeconds).
- Restaurar la velocidad original tras el tiempo.
- Evitar que el texto de puntuación sobrescriba el mensaje de recompensa antes de tiempo (WaitForSeconds).
<img width="1280" height="720" alt="Ejercicio7_2" src="https://github.com/user-attachments/assets/5017db7b-5d87-47e9-b5df-e029beecfc82" />
(Recompensa más allá de 100)
<img width="1280" height="720" alt="Ejercicio7" src="https://github.com/user-attachments/assets/9e874c25-7067-4955-8155-fdcfe606a790" />

## Hitos Ejercicio 8 (Escena del prototipo)
- Crear una escena coherente (mazmorra) con el prototipo del proyecto (aprovechamos los humanoides y escudos usados, aunque también añadimos nuevos elementos).
- Implementamos la orientación de los humanoides (Lookat()), su desplazamiento hacia el jugador (MoveTowards) a través de un objeto de referencia que detecta la cercanía del jugador con eventos y delegados.
- Configuramos los Colliders y Rigidbodys de los humanoides enemigos, del jugador (incluyendo su arma) y de los objetos del escenario. 
- Implementamos una interfaz que muestra la eliminación del enemigo (abatidos por la lanza) y la recompensa final del juego (captura del tesoro), cambiando su mensaje y color según el caso.
- Configuramos eventos y delegados en los enemigos y el cofre que conecten con la UI.
- Comprobar que el jugador puede interactuar con los elementos de la escena.
<img width="1280" height="720" alt="Ejercicio8" src="https://github.com/user-attachments/assets/6f5d1e03-7817-4383-af87-cf903da7133c" />

## Hitos Ejercicio 9 (Ejercicio 3 con el cubo físico)
- Partir de la escena y la mecánica del ejercicio 3.
- Añadir y configurar un Rigidbody en el cubo (con físicas).
- Adaptar el movimiento del cubo para utilizar el sistema de físicas, mediante Rigidbody.MovePosition en FixedUpdate().
- Mantener la detección de colisiones con los humanoides de ambos grupos.
- Verificar que los eventos o mensajes siguen activándose correctamente con el cubo físico.
<img width="1280" height="720" alt="Ejercicio9" src="https://github.com/user-attachments/assets/518e0fa5-4601-4e7c-887a-f9a245dbf6d1" />

 



