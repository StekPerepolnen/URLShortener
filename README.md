Аналог сервиса для сжатия ссылок. Пользователю доступны две страницы. На главной странице сайта находится форма для сжатия ссылок. На второй - список созданных им ссылок с датой и временем создания, оригинальной ссылкой, сжатой версией и количеством переходов по ссылке.
Регистрации не предусмотрено.

Технологии ASP.NET MVC, Angular 2, TypeScript, Bootstrap, MSSQL, EF

проект сайта              - URLShortener.Web;
api проекта               - URLShortener.WebAPIService;
конвертация строки url    - URLShortener.Utils;
доступ к бд               - URLShortener.DAOService;

Перед запуском в студии, загрузить необходимыее пакеты.
package.json -> Restore Packages.
собрать проект URLShortener.Web и URLShortener.WebAPIService.
Можно запускать проект.

Сама БД находится в URLShortener.WebAPIService\App_Data\DbUrl.mdf, поэтому нет необходимости создавать бд самостоятельно. 
При разворачивании сайта на IIS, строки обращения к api можно поменять в файле /URLShortener.Web/config.development.json

посмотреть можно здесь http://92.63.107.111:46274/
