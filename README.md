# log
Se debe primeramente iniciar un nuevo registro de usuario el cual se envia de la siguiente manera :

{
    "firstName": "Cristian",
    "lastName": "Emmanuel",
    "username": "Cristian13",
    "password": "my-pass"
}
Luego se autentica el usuario de la siguiente manera :

{
    "username": "Cristian13",
    "password": "my-pass"
}

y la respuesta seria algo similar a esto :

{
    "id": 1,
    "username": "Cristian13",
    "firstName": "Cristian",
    "lastName": "Emmanuel",
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEiLCJuYmYiOjE2NDkwOTY2NjksImV4cCI6MTY0OTcwMTQ2OSwiaWF0IjoxNjQ5MDk2NjY5fQ.0
    xkIbVitSlSo0Yd2w_IhQBWIoYHSHm-O0joIYlawzho"
}
Con respecto a la consulta de usuario se lo hace en el get simplemente sin parametros y el respons es :
[
    {
        "id": 1,
        "firstName": "Cristian",
        "lastName": "Emmanuel",
        "username": "Cristian13"
    },
    {
        "id": 2,
        "firstName": "Jack",
        "lastName": "Daniels",
        "username": "Jacks"
    },
    {
        "id": 3,
        "firstName": "Jim",
        "lastName": "Rock",
        "username": "Cristian13"
    }
]
En el caso de las provincias seria igual ingresando el nombre d e la misma y el respons seria el de la api de la provincia :

{
    "provincias": [
        {
            "nombre": "Santiago del Estero",
            "id": "86",
            "centroide": {
                "lat": -27.782412,
                "lon": -63.252387
            }
        }
    ],
    "cantidad": 1,
    "total": 1,
    "inicio": 0,
    "parametros": { ... }
}
