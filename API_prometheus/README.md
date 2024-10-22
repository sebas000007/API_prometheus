# Mi API de Productos

Esta es una API RESTful construida en C# utilizando ASP.NET Core. Permite gestionar un conjunto de productos, con operaciones para crear, leer, actualizar y eliminar productos.

## Descripción

La API simula una base de datos en memoria y proporciona los siguientes endpoints:

- `GET /api/productos`: Obtiene la lista de todos los productos.
- `GET /api/productos/{id}`: Obtiene un producto específico por su ID.
- `POST /api/productos`: Crea un nuevo producto.
- `PUT /api/productos/{id}`: Actualiza un producto existente.
- `DELETE /api/productos/{id}`: Elimina un producto específico por su ID.

Además, esta API está configurada para exponer métricas a través de Prometheus, permitiendo el monitoreo de solicitudes.

## Requisitos

- [.NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (o cualquier IDE que soporte .NET)

## Instalación

1. Clona este repositorio:
   ```bash
   git clone https://github.com/tu-usuario/nombre-del-repositorio.git
   ```

2. Navega al directorio del proyecto:
   ```bash
   cd nombre-del-repositorio
   ```

3. Restaura las dependencias:
   ```bash
   dotnet restore
   ```

4. Ejecuta la aplicación:
   ```bash
   dotnet run
   ```

## Acceso a la API

Una vez que la aplicación esté en funcionamiento, puedes acceder a la API en:

- **URL base**: `http://localhost:5018/api/productos`

Para explorar la API de manera interactiva, puedes usar Swagger en:

- **Swagger UI**: `http://localhost:5018/swagger`

## Métricas

La API también expone métricas para Prometheus en:

- **Métricas**: `http://localhost:5018/metrics`

## Contribuciones

Las contribuciones son bienvenidas. Si deseas contribuir, sigue estos pasos:

1. Realiza un fork del proyecto.
2. Crea una nueva rama (`git checkout -b feature/nueva-caracteristica`).
3. Realiza tus cambios y haz un commit (`git commit -m 'Agrega nueva característica'`).
4. Envía tus cambios a tu fork (`git push origin feature/nueva-caracteristica`).
5. Abre un pull request.

## Licencia

Este proyecto está licenciado bajo la [MIT License](LICENSE).

## Contacto

Para cualquier duda o consulta, puedes contactarme a través de:

- **Correo electrónico**: tu-correo@ejemplo.com

pruebaaaaaa