# Перелік завдань

### Завдання 1 - Інкапсуляція і наслідування

Тематика: Автомобілі і вантаж

1. Створити базовий клас Vehicle з інкапсульованими методами brand, fuelLevel
2. Створити публічні методи для роботи з fuelLevel - refuel(amount) та drive(km)
3. Створити клас Truck, який може перевозити вантаж типу Cargo, використовує додаткове паливо на додаткові навантаження (перевизначити метод drive)

### Завдання 2 - Абстракція, інтерфейси, інверсія залежностей

Тематика: Платіжна система

1. Створити інтерфейс IPaymentMethod, який має метод ProcessPayment(amount)
2. Реалізувати два класи CreditCardPayment і PayPalPament
3. Створити клас PaymentProcessor, який приймає в метод Execute будь-який спосіб оплати

### Завдання 3 - Асинхронність

Тематика: Автомобілі і вантаж

1. Додати у клас Truck метод DeliverAsync(distanceKm) з імітацією очікування.
2. Реалізувати можливість скасування доставки
3. Додати обробку виключень try-catch

### Завдання 4 - Тестування

Тематика: Автомобілі і вантаж

1. Тестування Load: Один, багато, пустий масив
2. Тестування Unload: Є/Нема в переліку
3. Тестування Drive: Перевірка використання палива, перевірка виключень нестачі палива

### Завдання 5 - Паттерни GoF

#### Частина 1

1. Реалізувати Strategy для PaymentProcessor: SetStrategy, Execute, інкапсулювати стратегію
2. Реалізувати Builder для Truck: реалізувати телескопічний конструктор TruckBuilder
3. Реалізувати Decorator для Vehicle: Truck реалізує IVehicle, AirConditionedTruck і GPSTrackedTruck реалізують IVehicle і додає логу до Drive

#### Частина 2

Завдання: Реалізувати паттерни GoF

1. Creational
		
	1.1 Factory Method
	
	1.2 Abstract Factory

	1.3 Builder

	1.4 Prototype

	1.5 Singleton 

2. Structural

	2.1 Adapter

	2.2 Bridge

	2.3 Composite

	2.4 Decorator

	2.5 Facade

	2.6 Flyweight

	2.7 Proxy

3. Behavioral

	3.1 Chain of Responsibilities

	3.2 Command

	3.3 Iterator

	3.4 Mediator

	3.5 Memento

	3.6 Observer
	
	3.7 State

	3.8 Strategy
	
	3.9 Template Method

	3.10 Visitor