**Описание**

Аналог сервиса для сжатия ссылок. Пользователю доступны две страницы. На главной странице сайта находится форма для сжатия ссылок. На второй - список созданных им ссылок с датой и временем создания, оригинальной ссылкой, сжатой версией и количеством переходов по ссылке.
Регистрации не предусмотрено.
<hr>
Технологии ASP.NET MVC, Angular 2, TypeScript, Bootstrap, MSSQL, EF

Microsoft VS 2015 Update 3

npm 5.3.0

TypeScript 2.5.2.0
<hr>
проект сайта              - URLShortener.Web;

api проекта               - URLShortener.WebAPIService;

конвертация строки url    - URLShortener.Utils;

доступ к бд               - URLShortener.DAOService;

Перед запуском в студии, загрузить необходимыее пакеты
package.json -> Restore Packages

Собрать все решение

Запустить проект URLShortener.Web

<hr>
Сама БД находится в URLShortener.WebAPIService\App_Data\DbUrl.mdf, поэтому нет необходимости создавать бд самостоятельно

При разворачивании сайта на IIS, строки обращения к api можно поменять в файле /URLShortener.Web/config.development.json
<hr>
[посмотреть можно здесь](http://92.63.107.111:46274/)
