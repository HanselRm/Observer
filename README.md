# Observer

Sistema de notificación de cupos

Crear una aplicación que notifique a los estudiantes, profesores y empleados administrativos del ITLA, cuando una asignatura tenga cupo, enviando un correo electronico a los estudiantes interesados en esa materia.

Se requiere que implemente el patron de diseño Observer.

La aplicacion debe manejar estudiantes (debe tener al menos 5, pueden estar hardcode)
La aplicacion debe manejar profesores (debe tener al menos 5, pueden estar hardcode)
La aplicacion debe manejar empleados (debe tener al menos 5, pueden estar hardcode) 
La aplicacion debe manejar materias  (debe tener al menos 5, pueden estar hardcode)

Haga una abtracción y piense en los atributos de estas clases.

Para las materias, defina un atributo que permita determinar si tiene cupo o no, para que cuando el valor de este atributo cambie se notifique con un correo electrónico a los objetos interesados.
