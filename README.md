# Desafio_PostProcess
Desafío Post Process y Reflection Probes - Curso Desarrollo de videojuegos Coderhouse
>> Consigna:
Se pedirá que los alumnos entreguen una escena de Unity, donde deberán:
- Incluir un efecto permanente de post procesado.
- Incorporar al menos dos volúmenes con un perfil de post procesado diferente.
- Sumar la interacción de alguna variable del post procesado.
- Utilizar al menos dos reflection probe, con el material correspondiente, para observar la
funcionalidad de las reflexiones.
----------------------------------------------------
>> Aclaraciones:
- Versión de Unity: 2021.3.5f1
- Se agregó un Post Process Volume al GameObject CrossWoodPP, incorporándole el efecto Vignette. Al acercarse al GameObject "crossWood" se activa el efecto.
- Se agregó un Post Process Volume al GameObject GlobalPP, incorporándole los efectos Grain y Bloom. También tiene incorporado el efecto Color Grading que se activa al estar en contacto con el GameObject "cross", y se desactiva al dejar de estar en contacto con el mismo.
- La interacción con el GameObject "cross" antes mencionada, se controla a través de código, utilizando una variable de PostProcessVolume en el script "GlobalVolumeManager" y llamando al método OnDamageFilter en el script "PlayerCollision".
- Se agregaron 2 Reflection Probes, uno en el GameObject "Mirror" y otro en el GameObject "Sphere".

