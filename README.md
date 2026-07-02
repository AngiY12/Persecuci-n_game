# 🎯 Persecución Game (IA en Unity)

Un proyecto de videojuego 3D desarrollado en Unity enfocado en la implementación de lógicas de Inteligencia Artificial (IA) optimizadas para el comportamiento y persecución de enemigos.

## 🎮 Características y Mecánicas de la IA

Este proyecto destaca por evitar el uso exclusivo de físicas prefabricadas (como NavMesh), implementando en su lugar cálculos matemáticos y vectoriales propios para el comportamiento de los enemigos:

* **Visión por Cono (FOV):** Los enemigos utilizan cálculo de vectores y distancias (`sqrMagnitude`) para detectar al jugador solo si este entra en su rango específico y dentro de su ángulo de visión frontal.
* **Persecución Predictiva:** La IA calcula la velocidad relativa entre su propia posición y la del jugador para predecir matemáticamente el punto de intercepción futuro, logrando emboscadas más inteligentes.
* **Detección basada en Movimiento:** Mecánica reaccionaria donde los enemigos evalúan la posición del jugador frame a frame; si el jugador se queda completamente quieto, la persecución se detiene.

## 💻 Tecnologías Utilizadas

* **Motor Gráfico:** Unity 3D
* **Lenguaje:** C#
* **Conceptos Aplicados:** Álgebra lineal (Vectores), optimización de rendimiento (evitando raíces cuadradas en cálculos de distancia), y manipulación de `Transform`.

---
## 👩‍💻 Desarrollador

**Angeli Tello** *Estudiante de Ingeniería en Ciencias de la Computación*
