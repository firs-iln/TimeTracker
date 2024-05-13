# TimeTracker
OOP task (spring semester)

**Тема: Система учета и контроля рабочего времени сотрудников** \
\
**Номер команды**: 13

Состав команды:

1. Фирсов Илья Романович
2. Едигарева Дарья Романовна
3. Даньшин Семен Алексеевич 
4. Сачук Алина Алексеевна
5. ~~Кукишев Никита Антонович~~
6. Мальцев Илья Игоревич

Доска: https://tulip-anger-bce.notion.site/9374c3e4192045ec8f5c6a7ce26f6931?v=c6c205309f1d4e748ad1619a2347bef4&pvs=4


Эта система предоставляет следующие основные функции:

- Учет рабочего времени сотрудников.
- Управление отпусками сотрудников.
- Генерация отчетов о рабочем времени и отпусках.

## Доменные сущности

1. **Сотрудник (Employee)**
    - Уникальный идентификатор (ID)
    - ФИО
    - Паспортные данные
    - Телефон сотрудника
    - Почта сотрудника
    - Дата рождения

2. **Учет рабочего времени (TimeRecord)**
    - Уникальный идентификатор записи
    - Идентификатор сотрудника
    - Дата и время начала рабочего времени
    - Дата и время окончания рабочего времени

3. **Учет задач сотрудника**
    - Уникальный идентификатор записи
    - Идентификатор сотрудника
    - Идентификатор таски 
    - Дата и время начала таски
    - Дата и время окончания таски

4. **Таска**
   - Уникальный индентификатор таски
   - Описание таски
   - Статус таски
   - Дедлайн таски
   - Индентификатор отдела

5. **Отпуск (Vacation)**
    - Уникальный идентификатор
    - Идентификатор сотрудника
    - Тип отпуска
    - Дата начала отпуска
    - Дата окончания отпуска

6. **Отдел или Подразделение (Department)**
    - Уникальный идентификатор отдела
    - Название отдела
    - Руководитель отдела

7. **Должность (Position)**
    - Уникальный идентификатор должности
    - Название должности
    - Описание должности

8. **Должность сотрудника**
   - Уникальный идентификатор сотрудника(ID)
   - Уникальный идентификатор должности
   - Дата начала работы
   - Дата конца работы (optional)
   - График работы
   - Оклад
   - Идентификатор отдела

9. **Пользователь системы (User)**
    - Уникальный идентификатор пользователя
    - Идентификатор сотрудника
    - Юзернейм
    - Хэш пароля
    - Роль

10. **JWT-токен**
    - Access
    - Refresh
    - User_id

# Эндпоинты RESTful API

Ниже представлены эндпоинты для управления системой учета и контроля рабочего времени сотрудников через RESTful API.

## Сотрудник (Employee)

- `POST /employees`: Создание нового сотрудника.
- `GET /employees`: Получение списка всех сотрудников.
- `GET /employees/{id}`: Получение информации о сотруднике по ID.
- `PUT /employees/{id}`: Обновление информации о сотруднике по ID.
- `DELETE /employees/{id}`: Удаление сотрудника по ID.

## Учет рабочего времени (TimeRecord)

- `POST /timeRecords`: Добавление записи о рабочем времени.
- `GET /timeRecords`: Получение списка всех записей о рабочем времени.
- `GET /timeRecords/{id}`: Получение записи о рабочем времени по ID.
- `PUT /timeRecords/{id}`: Обновление записи о рабочем времени по ID.
- `DELETE /timeRecords/{id}`: Удаление записи о рабочем времени по ID.

## Учет задач сотрудника (TaskRecord)

- `POST /taskRecords`: Добавление записи о задаче сотрудника.
- `GET /taskRecords`: Получение списка всех задач сотрудников.
- `GET /taskRecords/{id}`: Получение записи о задаче сотрудника по ID.
- `PUT /taskRecords/{id}`: Обновление записи о задаче сотрудника по ID.
- `DELETE /taskRecords/{id}`: Удаление записи о задаче сотрудника по ID.

## Таски (Task)

- `POST /tasks`: Создание новой задачи.
- `GET /tasks`: Получение списка всех задач.
- `GET /tasks/{id}`: Получение задачи по ID.
- `PUT /tasks/{id}`: Обновление задачи по ID.
- `DELETE /tasks/{id}`: Удаление задачи по ID.

## Отпуск (Vacation)

- `POST /vacations`: Добавление отпуска сотрудника.
- `GET /vacations`: Получение списка всех отпусков.
- `GET /vacations/{id}`: Получение отпуска по ID.
- `PUT /vacations/{id}`: Обновление отпуска по ID.
- `DELETE /vacations/{id}`: Удаление отпуска по ID.

## Отдел или Подразделение (Department)

- `POST /departments`: Создание нового отдела.
- `GET /departments`: Получение списка всех отделов.
- `GET /departments/{id}`: Получение отдела по ID.
- `PUT /departments/{id}`: Обновление отдела по ID.
- `DELETE /departments/{id}`: Удаление отдела по ID.

## Должность (Position)

- `POST /positions`: Добавление новой должности.
- `GET /positions`: Получение списка всех должностей.
- `GET /positions/{id}`: Получение должности по ID.
- `PUT /positions/{id}`: Обновление должности по ID.
- `DELETE /positions/{id}`: Удаление должности по ID.

## Пользователь системы (User)

- `POST /users`: Регистрация нового пользователя.
- `GET /users`: Получение списка пользователей.
- `GET /users/{id}`: Получение информации о пользователе по ID.
- `PUT /users/{id}`: Обновление пользователя по ID.
- `DELETE /users/{id}`: Удаление пользователя по ID.

## Аутентификация и авторизация

- `POST /auth/login`: Аутентификация пользователя и получение JWT.
- `POST /auth/refresh`: Обновление JWT токенов.

Каждый эндпоинт позволяет выполнять определенные операции с соответствующими сущностями в системе. При использовании этих эндпоинтов необходимо обеспечить правильную обработку запросов и защиту от несанкционированного доступа.


```json

{
  "Employee": {
    "id": "123",
    "fullName": "Иванов Иван Иванович",
    "passportData": "4500 123456",
    "phoneNumber": "+7 (999) 123-45-67",
    "email": "ivanov@example.com",
    "dateOfBirth": "1980-01-01"
  }
}
```
```json       
{
   "TimeRecord": {
      "recordId": "456",
      "employeeId": "123",
      "startTime": "2024-02-21T09:00:00Z",
      "endTime": "2024-02-21T17:00:00Z"
   }
} 
```
```json
{
   "TaskRecord": {
      "recordId": "789",
      "employeeId": "123",
      "taskId": "321",
      "startTime": "2024-02-21T09:00:00Z",
      "endTime": "2024-02-21T12:00:00Z"
   }
}
```
```json
{
  "Task": {
      "taskId": "321",
      "description": "Complete project proposal",
      "status": "In Progress",
      "deadline": "2024-03-15",
      "departmentId": "ABC"
  }
}
```
```json
{
   "Vacation": {
      "vacationId": "654",
      "employeeId": "123",
      "type": "Paid",
      "startDate": "2024-05-01",
      "endDate": "2024-05-10"
   }
}
```
```json
{
   "Department": {
      "departmentId": "ABC",
      "name": "Sales Department",
      "managerId": "123"
   }
}
```
```json
{
  "Position": {
    "positionId": "789",
    "title": "Sales Manager",
    "description": "Responsible for managing sales team",
    "departmentId": "ABC"
  }
}
```
```json
{
   "EmployeePosition": {
      "employeeId": "123",
      "positionId": "789",
      "startDate": "2020-01-01",
      "endDate": null,
      "workSchedule": "9-5",
      "salary": "50000"
   }
}
```
```json
{
   "User": {
      "userId": "101",
      "employeeId": "123",
      "username": "ivanov",
      "passwordHash": "hashed_password",
      "role": "Employee"
   }
}
```
```json
{
   "JWTToken": {
      "accessToken": "access_token_value",
      "refreshToken": "refresh_token_value",
      "userId": "101"
   }
}
```