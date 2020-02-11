# Intro-TDD
Repositorio para demostración de uso de TDD.

Resolveremos un problema sencillo y configuraremos un servidor de integración continúa para compilar y ejecutar nuestros tests unitarios en cada cambio integrado.

## Problema a resolver
Debemos construir una cuenta corriente que permita realizar operaciones depositar y extraer.
La idea es incorporar los requerimientos uno a uno, evaluando cada vez sólo el requerimiento actual.
1. La cuenta corriente debe poseer un saldo actual que debe poder consultarse.
2. La cuenta corriente debe permitir depositar un monto que debe incrementar el saldo actual.
3. El saldo a depositar debe ser mayor a 0 y menor a 100.000.000.
4. La cuenta corriente debe permitir extraer un monto, el monto extraído debe actualizar el saldo actual.
5. El saldo a extraer debe ser mayor a cero.
6. El saldo a extraer debe ser menor o igual al saldo actual de la cuenta.
7. Opcionalmente las cuentas pueden tener un límite de descubierto, el saldo a extraer debe ser menor o igual al saldo de la cuenta más el límite de descubierto.


