# qaseio.testing
Graduate work for Auto QA C#. QAC03-onl. Testing Qase.io

Test Automation Framework состоит из 3 архитектурных слоев:
- Bussines Objects - содержит объекты относящиеся к тестируемому продукту, такие как модели PageObject, ServiceObject, объекты ответов API, общие шаги API и UI, Builder объектов
- Core - содержит классы и методы, составляющие ядро фрэмворка, которое можно переиспользовать. Такие как базовые объекты, движки конфигураций, web элементы страниц, объекты браузера, хэлперы и тд.
- Test - содержат тестовые классы по UI и API тестированию.
  
Всего реализовано 11 тестов, из которых 7 UI и 4 API теста.
Тест-кейсы описаны в TMS [qase.io](https://app.qase.io/project/QIT?previewMode=side)

## Authors

- [@Starostin Alexander](https://github.com/Starmaster1)

## Tech Stack

**Test framework:** NUnit

**Logging:** NLog

**Reporting:** Allure

**Browser automation:** Selenium

**Rest client:** RestSharp

**Generator fake data:** Faker


## Quick start

1. Зарегистрироваться на TMS qase.io.
2. Получить API token по ссылке [qase.io API Token](https://app.qase.io/user/api/token).
3. Клонировать репозиторий [qaseio.testing](https://github.com/Starmaster1/qaseio.testing.git). 
4. Открыть репозиторий в Microsoft Visual studio.
5. В файле appsettings.json заполнить своими значениями.
6. Выполнить Buid solution.

## Run Tests

Для запуска всех тестов выполнит команду
```bash
 dotnet test -s Test/runsettings/TestData.runsettings
```
Для запуска группы тестов по категории можно выполнить команду, например 

```bash
  dotnet test -s Test/runsettings/TestData.runsettings --filter TestCategory=API
```
Либо в  Visual Studio можно использовать Test Explorer.
