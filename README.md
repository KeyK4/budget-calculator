#Техническое задание

## Постановка задачи
Необходимо разработать приложение с графическим интерфейсом "Калькулятор семейного бюджета", в котором будет вестись 
учет трат с распределением по категориям и возможностью планирования, а также доходов. На основе этих данных будет 
проводиться анализ дефицита или профицита бюджета.

## Основные требования
* Приложение необходимо реализовать на языке C# с использованием фреймворка .Net Windows Forms
* Пользовательский ввод должен быть реализован в отдельной форме с клавиатуры и с помощью встроенных элементов 
фреймворка
* Траты и доходы должны делиться на плановые и непредвиденные
* Планирование должно подразумевать дальнейшее совершение трат или получение дохода с изменением номинала, а также 
дальнейшим анализом изменения цены
* По запросу должно приводиться аналитика с распределением трат на категории, отношением плановых доходов/расходов к
реальным и итоговым профицитом или дефицитом бюджета
* Анализируемый отрезок должен быть выбираемым(месяц, 3 месяца, год)
* Все записи должны сохраняться локально

## Недопустимые функции
В программе не должно быть:
* возможности переключения между несколькими аккаунтами
* загрузки чеков для автоматического ввода информации
* интеграции с другими программными обеспечениями

