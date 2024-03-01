# Fundamentos de HTML5, CSS e Javascript

## Aula 01 - Conceitos Fundamentais do HTML
- [HTML Tutorial](https://www.w3schools.com/html/default.asp)


## Aula 02 - Formulários

- [HTTP request methods](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods)

- [HTTP response status codes](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status)

- [HTML Forms](https://www.w3schools.com/html/html_forms.asp)

- [Galeria de Gráficos do Google](https://developers.google.com/chart/interactive/docs/gallery?hl=pt-br)

- [Http Status Dogs](https://httpstatusdogs.com/)

- [Http Cats](https://http.cat/)


## Aula 03 - Conceitos fundamentais do CSS 

- [CSS Tutorial](https://www.w3schools.com/css/default.asp)


## Aula 04 - Bootstrap Fundamentos

- [Bootstrap 5](https://www.w3schools.com/bootstrap5/index.php)
- [Bootstrap 5](https://getbootstrap.com/docs/5.0/getting-started/introduction/)

### Exercícios Bootstrap

1. [Containers](https://getbootstrap.com/docs/5.0/layout/containers/)
2. [Grid System](https://getbootstrap.com/docs/5.0/layout/grid/)
3. [Typography](https://getbootstrap.com/docs/5.0/content/typography/)
4. [Tables](https://getbootstrap.com/docs/5.0/content/tables/)
5. [Forms](https://getbootstrap.com/docs/5.0/forms/overview/)
6. [Buttons](https://getbootstrap.com/docs/5.0/components/buttons/)
7. [Images](https://getbootstrap.com/docs/5.0/content/images/)
8. [Alerts](https://getbootstrap.com/docs/5.0/components/alerts/)
9. [Badges](https://getbootstrap.com/docs/5.0/components/badge/)
10. [Progress](https://getbootstrap.com/docs/5.0/components/progress/)
11. [Spinners](https://getbootstrap.com/docs/5.0/components/spinners/)
12. [Dropdowns](https://getbootstrap.com/docs/5.0/components/dropdowns/)
13. [Navs](https://getbootstrap.com/docs/5.0/components/navs/)
14. [Navbar](https://getbootstrap.com/docs/5.0/components/navbar/)
15. [Pagination](https://getbootstrap.com/docs/5.0/components/pagination/)
16. [Breadcrumbs](https://getbootstrap.com/docs/5.0/components/breadcrumb/)
17. [Tooltips](https://getbootstrap.com/docs/5.0/components/tooltips/)
18. [Popovers](https://getbootstrap.com/docs/5.0/components/popovers/)
19. [Modals](https://getbootstrap.com/docs/5.0/components/modal/)
20. [Carousel](https://getbootstrap.com/docs/5.0/components/carousel/)
21. [Accordions](https://getbootstrap.com/docs/5.0/components/accordion/)
22. [List Groups](https://getbootstrap.com/docs/5.0/components/list-group/)
23. [Cards](https://getbootstrap.com/docs/5.0/components/card/)
24. [Spinners](https://getbootstrap.com/docs/5.0/components/spinners/)
25. [Toasts](https://getbootstrap.com/docs/5.0/components/toasts/)
26. [Offcanvas](https://getbootstrap.com/docs/5.0/components/offcanvas/)
27. [Collapse](https://getbootstrap.com/docs/5.0/components/collapse/)
28. [Scrollspy](https://getbootstrap.com/docs/5.0/components/scrollspy/)
29. [Utilities](https://getbootstrap.com/docs/5.0/utilities/borders/)
30. [Responsive Breakpoints](https://getbootstrap.com/docs/5.0/layout/breakpoints/)
31. [Starter Template](https://getbootstrap.com/docs/5.0/getting-started/introduction/#starter-template)


## Aula 05 - Bootstrap Construindo uma Aplicação

- [Bootswatch](https://bootswatch.com/)


## Aula 06 - Javascript

- [JavaScript Tutorial](https://www.w3schools.com/js/default.asp)

- [LearnTypeScript](https://learn.microsoft.com/pt-br/training/paths/build-javascript-applications-typescript/)

- [TypeScript](https://www.typescriptlang.org/)

- [TypeScript Tutorial](https://www.w3schools.com/typescript/default.asp)

- [Javascript Minifier](https://medium.com/@anandkiit94/minifying-typescript-code-d0529189daf0)

```powershell
npm i — save -dev jsmin
npm i — — save-dev uglify.js
npm run minify
```


## Aula 07 - TypeScript


- [TypeScript](https://www.typescriptlang.org/)

- [TypeScript Tutorial](https://www.w3schools.com/typescript/)

- [TypeScript Playground](https://www.typescriptlang.org/play)

- [TypeScript Handbook](https://www.typescriptlang.org/docs/handbook/intro.html)

- [TypeScript Microsoft Learn](https://learn.microsoft.com/pt-br/training/paths/build-javascript-applications-typescript/?source=learn)



0 - Instalar o Node.js
[Node.js](https://nodejs.org/en/)

```powershell
npm install
```

1 - Instalar o TypeScript
```powershell
npm install -g typescript
```

2 - Verificar a versão do TypeScript
```powershell   
tsc -v
```

3 - Criar um arquivo TypeScript
```typescript
let mensagem: string = "Olá, mundo!";
console.log(mensagem);
```

4 - Configurar o arquivo tsconfig.json
```Powershell
tsc --init

npx -p typescript tsc --init
```

```json
{
  "compilerOptions": {
    "target": "es6",
    "outDir": "build",
    "strict": true
  }
}
```

5 - Compilar o arquivo TypeScript
```powershell
tsc nome-do-arquivo.ts
```


## Aula 08 - JQUERY e JQUERY AJAX

- [jQuery Tutorial](https://www.w3schools.com/jquery/default.asp)

- [JQUERY AJAX Introduction](https://www.w3schools.com/jquery/jquery_ajax_intro.asp)

- [AJAX Getting Started](https://udn.realityripple.com/docs/Web/Guide/AJAX/Getting_Started)


```html
<!DOCTYPE html>
<html>
<head>
    <title>Carregamento de Conteúdo com AJAX e jQuery</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#load_content_button').click(function(){
                $('#content').load('conteudo.html');
            });
        });
    </script>
</head>
<body>
    <button id="load_content_button">Carregar Conteúdo</button>
    <div id="content"></div>
</body>
</html>
```
*conteudo.html*
```html
<p>Este é um conteúdo carregado dinamicamente.</p>
```

## Aula 09 - JavaScript no Servidor - NODE.JS

- [Node.js Tutorial](https://www.w3schools.com/nodejs/default.asp)


## Links interessantes:

- [Exemplos Bootstrap](https://bootswatch.com/cerulean/)
- [Datatable](https://datatables.net/)
- [JQuery](https://jquery.com/)
- [JqueryTutorial](https://www.w3schools.com/jquery/)
- [Google Charts](https://developers.google.com/chart/)
- [Galeria Google Charts](https://developers.google.com/chart/interactive/docs/gallery?hl=pt-br)
