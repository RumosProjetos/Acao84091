Certamente, aqui estão 10 exemplos de exercícios com suas respostas envolvendo formulários HTML e jQuery:

## Exercícios de Formulários HTML e jQuery

</details>

### Exercício 1: Validação de Email
**Exercício:**
Crie um formulário com um campo de entrada para o email. Use jQuery para validar se o email inserido tem um formato válido quando o usuário sai do campo de entrada.

<details><summary>**Resposta:**</summary></summary>

```html
<!DOCTYPE html>
<html>
<head>
    <title>Validação de Email</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#email').blur(function(){
                var email = $(this).val();
                if(!isValidEmail(email)){
                    alert("Por favor, insira um email válido.");
                    $(this).val('');
                    $(this).focus();
                }
            });
            
            function isValidEmail(email) {
                var pattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
                return pattern.test(email);
            }
        });
    </script>
</head>
<body>
    <form>
        Email: <input type="email" id="email" name="email">
    </form>
</body>
</html>
```

</details>

### Exercício 2: Verificação de Senha

**Exercício:**
Crie um formulário com campos de entrada para senha e confirmação de senha. Use jQuery para verificar se os campos de senha e confirmação de senha correspondem quando o usuário sai do campo de confirmação de senha.

<details><summary>**Resposta:**</summary></summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Verificação de Senha</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#confirm_password').blur(function(){
                var password = $('#password').val();
                var confirmPassword = $(this).val();
                if(password !== confirmPassword){
                    alert("As senhas não correspondem.");
                    $('#password').val('');
                    $(this).val('');
                    $('#password').focus();
                }
            });
        });
    </script>
</head>
<body>
    <form>
        Senha: <input type="password" id="password" name="password"><br>
        Confirme a Senha: <input type="password" id="confirm_password" name="confirm_password">
    </form>
</body>
</html>
```

</details>

### Exercício 3: Contador de Caracteres
**Exercício:**
Crie um formulário com um campo de entrada de texto. Use jQuery para contar o número de caracteres conforme o usuário digita e exiba o resultado em tempo real.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Contador de Caracteres</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#input_text').keyup(function(){
                var characters = $(this).val().length;
                $('#character_count').text(characters);
            });
        });
    </script>
</head>
<body>
    <form>
        <textarea id="input_text"></textarea>
        <div>Contagem de caracteres: <span id="character_count">0</span></div>
    </form>
</body>
</html>
```

Claro, aqui estão os próximos exemplos:

</details>

### Exercício 4: Seleção de Opção Dependente
**Exercício:**
Crie um formulário com um campo de seleção e outro campo dependente. Use jQuery para alterar dinamicamente as opções do campo dependente com base na seleção feita pelo usuário no campo de seleção.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Seleção de Opção Dependente</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#select_option').change(function(){
                var selectedOption = $(this).val();
                if(selectedOption === 'A'){
                    $('#dependent_field').html('<option value="X">Opção X</option><option value="Y">Opção Y</option>');
                } else if(selectedOption === 'B'){
                    $('#dependent_field').html('<option value="P">Opção P</option><option value="Q">Opção Q</option>');
                } else {
                    $('#dependent_field').html('<option value="">Selecione uma opção</option>');
                }
            });
        });
    </script>
</head>
<body>
    <form>
        Campo de Seleção:
        <select id="select_option">
            <option value="">Selecione</option>
            <option value="A">Opção A</option>
            <option value="B">Opção B</option>
        </select><br>
        
        Campo Dependente:
        <select id="dependent_field">
            <option value="">Selecione uma opção</option>
        </select>
    </form>
</body>
</html>
```

</details>

### Exercício 5: Autocomplete
**Exercício:**
Crie um formulário com um campo de entrada. Use jQuery para fornecer sugestões de preenchimento automático à medida que o usuário digita no campo de entrada, baseando-se em uma lista de opções pré-definidas.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Autocomplete</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            var suggestions = ["Maçã", "Banana", "Pera", "Uva", "Laranja"];
            
            $('#input_text').autocomplete({
                source: suggestions
            });
        });
    </script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
</head>
<body>
    <form>
        Campo de Entrada:
        <input type="text" id="input_text">
    </form>
</body>
</html>
```

Claro, aqui estão mais exemplos:

</details>

### Exercício 6: Envio Assíncrono de Formulário
**Exercício:**
Crie um formulário com campos de entrada para nome e email. Use jQuery para enviar os dados do formulário para um servidor de forma assíncrona, sem atualizar a página.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Envio Assíncrono de Formulário</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#submit_button').click(function(e){
                e.preventDefault();
                var name = $('#name').val();
                var email = $('#email').val();
                $.ajax({
                    url: 'seu_script_de_processamento.php',
                    method: 'POST',
                    data: {name: name, email: email},
                    success: function(response){
                        alert(response); // Exibir mensagem de sucesso ou fazer outra ação
                    }
                });
            });
        });
    </script>
</head>
<body>
    <form>
        Nome: <input type="text" id="name" name="name"><br>
        Email: <input type="email" id="email" name="email"><br>
        <button type="submit" id="submit_button">Enviar</button>
    </form>
</body>
</html>
```

</details>

### Exercício 7: Máscara de Entrada
**Exercício:**
Crie um formulário com um campo de entrada para telefone. Use jQuery para aplicar uma máscara de entrada ao campo de telefone para formatá-lo automaticamente à medida que o usuário digita.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Máscara de Entrada</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.16/jquery.mask.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#phone').mask('(00) 00000-0000');
        });
    </script>
</head>
<body>
    <form>
        Telefone: <input type="text" id="phone" name="phone">
    </form>
</body>
</html>
```

Claro, aqui estão mais exemplos:

</details>

### Exercício 8: Campo de Data com Calendário Pop-up
**Exercício:**
Crie um formulário com um campo de entrada para data. Use jQuery para adicionar um calendário pop-up ao campo de data para facilitar a seleção da data pelo usuário.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Campo de Data com Calendário Pop-up</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css">
    <script>
        $(document).ready(function(){
            $('#date').datepicker({
                dateFormat: 'yy-mm-dd'
            });
        });
    </script>
</head>
<body>
    <form>
        Data: <input type="text" id="date" name="date">
    </form>
</body>
</html>
```

</details>

### Exercício 9: Validação de Campos Obrigatórios
**Exercício:**
Crie um formulário com campos obrigatórios. Use jQuery para verificar se os campos obrigatórios estão preenchidos antes de permitir que o formulário seja enviado.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Validação de Campos Obrigatórios</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#submit_button').click(function(){
                var name = $('#name').val();
                var email = $('#email').val();
                if(name === '' || email === ''){
                    alert("Por favor, preencha todos os campos obrigatórios.");
                    return false;
                }
            });
        });
    </script>
</head>
<body>
    <form>
        Nome: <input type="text" id="name" name="name"><br>
        Email: <input type="email" id="email" name="email"><br>
        <button type="submit" id="submit_button">Enviar</button>
    </form>
</body>
</html>
```

Claro, aqui está o último exemplo:

</details>

### Exercício 10: Adicionar e Remover Campos Dinamicamente
**Exercício:**
Crie um formulário com um botão para adicionar campos de entrada dinamicamente. Use jQuery para permitir que o usuário adicione e remova campos de entrada conforme necessário, como adicionar vários campos de endereço em um formulário de envio.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Adicionar e Remover Campos Dinamicamente</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            var max_fields = 5; // Número máximo de campos
            var wrapper = $("#input_fields_wrap"); // Container de campos
            var add_button = $("#add_field_button"); // Botão de adicionar campo

            var x = 1; // Inicial contador de campos
            $(add_button).click(function(e){
                e.preventDefault();
                if(x < max_fields){ // Checa limite máximo de campos
                    x++; // Incrementa contador
                    $(wrapper).append('<div><input type="text" name="field_' + x + '"/><a href="#" class="remove_field">Remover</a></div>'); // Adiciona campo de entrada
                }
            });

            $(wrapper).on("click",".remove_field", function(e){
                e.preventDefault(); $(this).parent('div').remove(); x--;
            });
        });
    </script>
</head>
<body>
    <form>
        <div id="input_fields_wrap">
            <button id="add_field_button">Adicionar Campo</button>
        </div>
    </form>
</body>
</html>
```

Neste exemplo, os campos de entrada são adicionados dinamicamente quando o usuário clica no botão "Adicionar Campo" e podem ser removidos clicando no link "Remover" ao lado de cada campo. O número máximo de campos é definido pela variável `max_fields`.

Claro, aqui estão 10 exemplos de exercícios com suas respostas envolvendo HTML, CSS e jQuery:

</details>

### Exercício 1: Toggle de Classe com jQuery
**Exercício:**
Crie uma página HTML com um botão. Ao clicar no botão, alterne a classe de um elemento na página para alterar seu estilo usando jQuery.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Toggle de Classe com jQuery</title>
    <style>
        .highlighted {
            background-color: yellow;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#toggle_button').click(function(){
                $('#element_to_toggle').toggleClass('highlighted');
            });
        });
    </script>
</head>
<body>
    <button id="toggle_button">Toggle Classe</button>
    <div id="element_to_toggle">Elemento para Alternar</div>
</body>
</html>
```

</details>

### Exercício 2: Animação com jQuery
**Exercício:**
Crie uma página HTML com um botão. Ao clicar no botão, faça um elemento na página se mover usando uma animação jQuery.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Animação com jQuery</title>
    <style>
        #animated_element {
            width: 100px;
            height: 100px;
            background-color: blue;
            position: relative;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#animate_button').click(function(){
                $('#animated_element').animate({left: '250px'});
            });
        });
    </script>
</head>
<body>
    <button id="animate_button">Animar</button>
    <div id="animated_element"></div>
</body>
</html>
```

Claro, aqui estão mais exemplos:

</details>

### Exercício 3: Dropdown Menu com CSS e jQuery
**Exercício:**
Crie um menu suspenso (dropdown menu) usando HTML, CSS e jQuery. Ao clicar em um item do menu, exiba seus subitens.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Dropdown Menu com CSS e jQuery</title>
    <style>
        .dropdown {
            position: relative;
            display: inline-block;
        }
        .dropdown-content {
            display: none;
            position: absolute;
            background-color: #f9f9f9;
            min-width: 100px;
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
            z-index: 1;
        }
        .dropdown:hover .dropdown-content {
            display: block;
        }
        .dropdown-content a {
            color: black;
            padding: 12px 16px;
            text-decoration: none;
            display: block;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('.dropdown').hover(function(){
                $(this).find('.dropdown-content').toggle();
            });
        });
    </script>
</head>
<body>
    <div class="dropdown">
        <span>Menu</span>
        <div class="dropdown-content">
            <a href="#">Item 1</a>
            <a href="#">Item 2</a>
            <a href="#">Item 3</a>
        </div>
    </div>
</body>
</html>
```

</details>

### Exercício 4: Slideshow com HTML, CSS e jQuery
**Exercício:**
Crie um slideshow simples usando HTML, CSS e jQuery para exibir uma sequência de imagens com controles de navegação.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Slideshow com HTML, CSS e jQuery</title>
    <style>
        .slideshow-container {
            position: relative;
            max-width: 1000px;
            margin: auto;
        }
        .mySlides {
            display: none;
        }
        .prev, .next {
            cursor: pointer;
            position: absolute;
            top: 50%;
            width: auto;
            padding: 16px;
            margin-top: -22px;
            color: white;
            font-weight: bold;
            font-size: 18px;
            transition: 0.6s ease;
            border-radius: 0 3px 3px 0;
        }
        .next {
            right: 0;
            border-radius: 3px 0 0 3px;
        }
        .prev:hover, .next:hover {
            background-color: rgba(0,0,0,0.8);
        }
        .numbertext {
            color: #f2f2f2;
            font-size: 12px;
            padding: 8px 12px;
            position: absolute;
            top: 0;
        }
        .caption-container {
            text-align: center;
            background-color: rgba(0,0,0,0.8);
            padding: 2px 16px;
            color: white;
        }
        .dot {
            cursor: pointer;
            height: 15px;
            width: 15px;
            margin: 0 2px;
            background-color: #bbb;
            border-radius: 50%;
            display: inline-block;
            transition: background-color 0.6s ease;
        }
        .active, .dot:hover {
            background-color: #717171;
        }
        .fade {
            animation-name: fade;
            animation-duration: 1.5s;
        }
        @keyframes fade {
            from {opacity: .4}
            to {opacity: 1}
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        var slideIndex = 1;
        showSlides(slideIndex);
        function plusSlides(n) {
            showSlides(slideIndex += n);
        }
        function currentSlide(n) {
            showSlides(slideIndex = n);
        }
        function showSlides(n) {
            var i;
            var slides = $(".mySlides");
            var dots = $(".dot");
            if (n > slides.length) {slideIndex = 1}
            if (n < 1) {slideIndex = slides.length}
            for (i = 0; i < slides.length; i++) {
                slides[i].style.display = "none";
            }
            for (i = 0; i < dots.length; i++) {
                dots[i].className = dots[i].className.replace(" active", "");
            }
            slides[slideIndex-1].style.display = "block";
            dots[slideIndex-1].className += " active";
        }
    </script>
</head>
<body>
    <div class="slideshow-container">
        <div class="mySlides fade">
            <img src="img1.jpg">
        </div>
        <div class="mySlides fade">
            <img src="img2.jpg">
        </div>
        <div class="mySlides fade">
            <img src="img3.jpg">
        </div>
        <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
        <a class="next" onclick="plusSlides(1)">&#10095;</a>
    </div>
    <br>
    <div style="text-align:center">
        <span class="dot" onclick="currentSlide(1)"></span> 
        <span class="dot" onclick="currentSlide(2)"></span> 
        <span class="dot" onclick="currentSlide(3)"></span> 
    </div>
</body>
</html>
```

Claro, aqui estão mais exemplos:

</details>

### Exercício 5: Carregamento de Conteúdo com AJAX e jQuery
**Exercício:**
Crie uma página HTML com um botão. Ao clicar no botão, carregue conteúdo de um arquivo externo usando AJAX e jQuery e exiba-o na página.

<details><summary>**Resposta:**</summary>
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

</details>

### Exercício 6: Tabs com HTML, CSS e jQuery
**Exercício:**
Crie um sistema de abas (tabs) usando HTML, CSS e jQuery. Ao clicar em uma aba, exiba o conteúdo correspondente e oculte os outros.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Tabs com HTML, CSS e jQuery</title>
    <style>
        .tabcontent {
            display: none;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('.tablinks').click(function(){
                var tabId = $(this).attr('data-tab');
                $('.tabcontent').hide();
                $('#' + tabId).show();
            });
        });
    </script>
</head>
<body>
    <div class="tab">
        <button class="tablinks" data-tab="tab1">Tab 1</button>
        <button class="tablinks" data-tab="tab2">Tab 2</button>
    </div>
    <div id="tab1" class="tabcontent">
        <h3>Conteúdo da Tab 1</h3>
        <p>Este é o conteúdo da Tab 1.</p>
    </div>
    <div id="tab2" class="tabcontent">
        <h3>Conteúdo da Tab 2</h3>
        <p>Este é o conteúdo da Tab 2.</p>
    </div>
</body>
</html>
```

Claro, aqui estão mais exemplos:

</details>

### Exercício 7: Drag and Drop com HTML, CSS e jQuery
**Exercício:**
Crie uma interface de arrastar e soltar (drag and drop) usando HTML, CSS e jQuery. Permita que o usuário arraste elementos para diferentes áreas na página.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Drag and Drop com HTML, CSS e jQuery</title>
    <style>
        .drag-container {
            width: 300px;
            height: 300px;
            border: 2px solid #000;
            margin: 20px;
            float: left;
        }
        .draggable {
            width: 50px;
            height: 50px;
            background-color: #00f;
            margin: 10px;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('.draggable').draggable();
        });
    </script>
</head>
<body>
    <div class="drag-container" id="container1">
        <div class="draggable"></div>
    </div>
    <div class="drag-container" id="container2">
        <div class="draggable"></div>
    </div>
</body>
</html>
```

</details>

### Exercício 8: Tooltip com HTML, CSS e jQuery
**Exercício:**
Crie um tooltip personalizado usando HTML, CSS e jQuery. Exiba o tooltip ao passar o mouse sobre um elemento e oculte-o ao remover o mouse.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Tooltip com HTML, CSS e jQuery</title>
    <style>
        .tooltip {
            position: relative;
            display: inline-block;
            border-bottom: 1px dotted black;
        }
        .tooltip .tooltiptext {
            visibility: hidden;
            width: 120px;
            background-color: #555;
            color: #fff;
            text-align: center;
            border-radius: 6px;
            padding: 5px 0;
            position: absolute;
            z-index: 1;
            bottom: 125%;
            left: 50%;
            margin-left: -60px;
            opacity: 0;
            transition: opacity 0.3s;
        }
        .tooltip:hover .tooltiptext {
            visibility: visible;
            opacity: 1;
        }
    </style>
</head>
<body>
    <div class="tooltip">Passe o mouse aqui
        <span class="tooltiptext">Tooltip Texto</span>
    </div>
</body>
</html>
```

Claro, aqui estão mais exemplos:

</details>

### Exercício 9: Menu de Navegação Responsivo com HTML, CSS e jQuery
**Exercício:**
Crie um menu de navegação responsivo usando HTML, CSS e jQuery. Ao clicar no ícone do menu, exiba ou oculte o menu de navegação.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Menu de Navegação Responsivo com HTML, CSS e jQuery</title>
    <style>
        .navbar {
            overflow: hidden;
            background-color: #333;
        }
        .navbar a {
            float: left;
            display: block;
            color: #f2f2f2;
            text-align: center;
            padding: 14px 20px;
            text-decoration: none;
            font-size: 17px;
        }
        .dropdown {
            float: left;
            overflow: hidden;
        }
        .dropdown .dropbtn {
            font-size: 17px;    
            border: none;
            outline: none;
            color: #f2f2f2;
            padding: 14px 20px;
            background-color: inherit;
            font-family: inherit;
            margin: 0;
        }
        .navbar a:hover, .dropdown:hover .dropbtn {
            background-color: #ddd;
            color: black;
        }
        .dropdown-content {
            display: none;
            position: absolute;
            background-color: #f9f9f9;
            min-width: 160px;
            box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
            z-index: 1;
        }
        .dropdown-content a {
            float: none;
            color: black;
            padding: 12px 16px;
            text-decoration: none;
            display: block;
            text-align: left;
        }
        .dropdown-content a:hover {
            background-color: #ddd;
        }
        .dropdown:hover .dropdown-content {
            display: block;
        }
        .icon {
            display: none;
        }
        @media screen and (max-width: 600px) {
            .navbar a:not(:first-child), .dropdown .dropbtn {
                display: none;
            }
            .navbar a.icon {
                float: right;
                display: block;
            }
            .navbar.responsive a {
                float: none;
                display: block;
                text-align: left;
            }
            .navbar.responsive .dropdown {
                float: none;
            }
            .navbar.responsive .dropdown-content {
                position: relative;
            }
            .navbar.responsive .dropdown .dropbtn {
                display: block;
                width: 100%;
                text-align: left;
            }
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('.icon').click(function(){
                $('.navbar').toggleClass('responsive');
            });
        });
    </script>
</head>
<body>
    <div class="navbar" id="myNavbar">
        <a href="#">Home</a>
        <a href="#">Link</a>
        <div class="dropdown">
            <button class="dropbtn">Dropdown
                <i class="fa fa-caret-down"></i>
            </button>
            <div class="dropdown-content">
                <a href="#">Link 1</a>
                <a href="#">Link 2</a>
                <a href="#">Link 3</a>
            </div>
        </div> 
        <a href="#">About</a>
        <a href="#">Contact</a>
        <a href="javascript:void(0);" class="icon">&#9776;</a>
    </div>
</body>
</html>
```

</details>

### Exercício 10: Modal com HTML, CSS e jQuery
**Exercício:**
Crie um modal simples usando HTML, CSS e jQuery. Exiba o modal ao clicar em um botão e permita que o usuário o feche clicando fora do modal ou em um botão de fechar.

<details><summary>**Resposta:**</summary>
```html
<!DOCTYPE html>
<html>
<head>
    <title>Modal com HTML, CSS e jQuery</title>
    <style>
        .modal {
            display: none; 
            position: fixed; 
            z-index: 1; 
            padding-top: 100px; 
            left: 0;
            top: 0;
            width: 100%; 
            height: 100%; 
            overflow: auto; 
            background-color: rgb(0,0,0); 
            background-color: rgba(0,0,0,0.4); 
        }
        .modal-content {
            background-color: #fefefe;
            margin: auto;
            padding: 20px;
            border: 1px solid #888;
            width: 80%;
        }
        .close {
            color: #aaa;
            float: right;
            font-size: 28px;
            font-weight: bold;
        }
        .close:hover,
        .close:focus {
            color: black;
            text-decoration: none;
            cursor: pointer;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function(){
            $('#open_modal_button').click(function(){
                $('.modal').css('display', 'block');
            });
            $('.close').click(function(){
                $('.modal').css('display', 'none');
            });
            $(window).click(function(event){
                if(event.target.className === 'modal'){
                    $('.modal').css('display', 'none');
                }
            });
        });
    </script>
</head>
<body>
    <button id="open_modal_button">Abrir Modal</button>
    <div class="modal">
        <div class="modal-content">
            <span class="close">&times;</span>
            <p>Este é um modal simples.</p>
            <p>Clique fora deste modal para fechar.</p>
        </div>
    </div>
</body>
</html>
```

Estes exemplos demonstram diferentes recursos e técnicas utilizando HTML, CSS e jQuery para criar interfaces interativas e responsivas.


