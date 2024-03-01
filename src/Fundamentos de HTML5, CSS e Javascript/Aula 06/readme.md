

### Exercícios JavaScript

Aqui estão 20 exercícios iniciais sobre JavaScript que cobrem conceitos básicos da linguagem:

1. **Variáveis e Operadores:**
```javascript
// Exercício 1: Declare duas variáveis, atribua valores a elas e faça a soma.
let a = 5;
let b = 10;
let soma = a + b;
console.log("A soma é:", soma);
```

2. **Condicionais:**
```javascript
// Exercício 2: Verifique se um número é par ou ímpar.
let numero = 7;
if (numero % 2 === 0) {
    console.log(numero + " é par.");
} else {
    console.log(numero + " é ímpar.");
}
```

3. **Laços (Loop):**
```javascript
// Exercício 3: Imprima os números de 1 a 5 usando um loop.
for (let i = 1; i <= 5; i++) {
    console.log(i);
}
```

4. **Funções:**
```javascript
// Exercício 4: Crie uma função que retorne a soma de dois números.
function soma(a, b) {
    return a + b;
}
console.log("A soma é:", soma(3, 4));
```

5. **Arrays:**
```javascript
// Exercício 5: Declare um array e imprima cada elemento.
let frutas = ["maçã", "banana", "laranja"];
for (let i = 0; i < frutas.length; i++) {
    console.log(frutas[i]);
}
```

6. **Métodos de Array:**
```javascript
// Exercício 6: Adicione um elemento a um array e remova outro.
let numeros = [1, 2, 3];
numeros.push(4); // Adiciona o número 4 ao array
numeros.pop();   // Remove o último elemento do array
console.log(numeros);
```

7. **Objetos:**
```javascript
// Exercício 7: Crie um objeto representando uma pessoa e imprima suas propriedades.
let pessoa = {
    nome: "João",
    idade: 30,
    profissao: "engenheiro"
};
console.log(pessoa.nome + " tem " + pessoa.idade + " anos e é " + pessoa.profissao + ".");
```

8. **Métodos de Objeto:**
```javascript
// Exercício 8: Adicione um método a um objeto e chame-o.
let carro = {
    marca: "Toyota",
    modelo: "Corolla",
    ano: 2020,
    descricao: function() {
        return this.marca + " " + this.modelo + " " + this.ano;
    }
};
console.log(carro.descricao());
```

9. **Manipulação de Strings:**
```javascript
// Exercício 9: Concatene duas strings.
let string1 = "Olá, ";
let string2 = "mundo!";
let mensagem = string1 + string2;
console.log(mensagem);
```

10. **Tratamento de Eventos (DOM):**
```javascript
// Exercício 10: Adicione um evento de clique a um elemento HTML.
document.getElementById("meuBotao").addEventListener("click", function() {
    alert("O botão foi clicado!");
});
```

11. **Validar Campo Obrigatório:**
```html
<!--Crie um formulário com um campo de texto obrigatório. Escreva um script que valide se o campo está preenchido antes de permitir o envio do formulário. -->
<form id="meuFormulario" onsubmit="return validarForm()">
    <input type="text" id="campoObrigatorio" required>
    <input type="submit" value="Enviar">
</form>

<script>
function validarForm() {
    let campo = document.getElementById("campoObrigatorio");
    if (campo.value.trim() === "") {
        alert("Por favor, preencha o campo obrigatório.");
        return false;
    }
    return true;
}
</script>
```

12. **Validar E-mail:**
```html
<!--Crie um formulário com um campo de e-mail. Escreva um script que valide se o e-mail inserido é válido antes de permitir o envio do formulário. -->
<form id="meuFormulario" onsubmit="return validarForm()">
    <input type="email" id="campoEmail" required>
    <input type="submit" value="Enviar">
</form>

<script>
function validarForm() {
    let email = document.getElementById("campoEmail").value;
    let regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!regex.test(email)) {
        alert("Por favor, insira um e-mail válido.");
        return false;
    }
    return true;
}
</script>
```

13. **Contador de Caracteres:**
```html
<!--Crie um campo de texto com um contador de caracteres. Escreva um script que atualize o contador de caracteres à medida que o usuário digita no campo de texto. -->
<form>
    <textarea id="campoTexto" oninput="contarCaracteres()"></textarea>
    <span id="contador">0 caracteres</span>
</form>

<script>
function contarCaracteres() {
    let texto = document.getElementById("campoTexto").value;
    let contador = document.getElementById("contador");
    contador.textContent = texto.length + " caracteres";
}
</script>
```

14. **Seleção de Opções:**
```html
<!--Crie um menu suspenso (select) com opções e um botão para exibir a opção selecionada. Escreva um script que exiba a opção selecionada quando o botão for clicado. -->
<form>
    <select id="opcoes">
        <option value="">Selecione uma opção</option>
        <option value="opcao1">Opção 1</option>
        <option value="opcao2">Opção 2</option>
        <option value="opcao3">Opção 3</option>
    </select>
    <button onclick="exibirOpcaoSelecionada()">Exibir Opção Selecionada</button>
</form>

<script>
function exibirOpcaoSelecionada() {
    let select = document.getElementById("opcoes");
    let opcaoSelecionada = select.options[select.selectedIndex].text;
    alert("Opção selecionada: " + opcaoSelecionada);
}
</script>
```

15. **Checkbox:**
```html
<!--Crie um formulário com um checkbox e um botão. Escreva um script que valide se o checkbox está marcado antes de permitir o envio do formulário. -->
<form>
    <input type="checkbox" id="checkbox"> Concordo com os termos.
    <button onclick="validarCheckbox()">Enviar</button>
</form>

<script>
function validarCheckbox() {
    let checkbox = document.getElementById("checkbox");
    if (!checkbox.checked) {
        alert("Por favor, concorde com os termos.");
        return false;
    }
    return true;
}
</script>
```

16. **Radio Buttons:**
```html
<!--Crie um formulário com radio buttons e um botão. Escreva um script que valide se um dos radio buttons está selecionado antes de permitir o envio do formulário. -->
<form>
    <input type="radio" name="opcao" value="opcao1"> Opção 1
    <input type="radio" name="opcao" value="opcao2"> Opção 2
    <input type="radio" name="opcao" value="opcao3"> Opção 3
    <button onclick="validarRadio()">Enviar</button>
</form>

<script>
function validarRadio() {
    let opcoes = document.getElementsByName("opcao");
    let selecionado = false;
    for (let i = 0; i < opcoes.length; i++) {
        if (opcoes[i].checked) {
            selecionado = true;
            break;
        }
    }
    if (!selecionado) {
        alert("Por favor, selecione uma opção.");
        return false;
    }
    return true;
}
</script>
```


17. **Máscara de Campo:**
```html
<!--Crie um campo de telefone que formate automaticamente o número inserido. Escreva um script que adicione parênteses, traço e espaços ao número à medida que o usuário digita. -->
<form>
    <input type="text" id="campoTelefone" oninput="formatarTelefone()">
</form>

<script>
function formatarTelefone() {
    let campo = document.getElementById("campoTelefone");
    let valor = campo.value.replace(/\D/g, "");
    let regex = /^(\d{3})(\d{4,5})(\d{4})$/;
    valor = valor.replace(regex, "($1) $2-$3");
    campo.value = valor;
}
</script>
```

18. **Upload de Arquivos:**
```html
<!--Crie um formulário com um campo de upload de arquivos e um botão. Escreva um script que valide se um arquivo foi selecionado antes de permitir o envio do formulário. -->
<form>
    <input type="file" id="arquivo">
    <button onclick="validarArquivo()">Enviar</button>
</form>

<script>
function validarArquivo() {
    let arquivo = document.getElementById("arquivo");
    if (arquivo.files.length === 0) {
        alert("Por favor, selecione um arquivo.");
        return false;
    }
    return true;
}
</script>
```

19. **Autocompletar:**
```html
<!--Crie um campo de texto com autocompletar usando a tag <datalist>. Adicione uma lista de opções para o autocompletar. -->
<form>
    <input type="text" id="campoCidade" list="cidades">
    <datalist id="cidades">
        <option value="São Paulo">
        <option value="Rio de Janeiro">
        <option value="Belo Horizonte">
        <option value="Curitiba">
        <option value="Porto Alegre">
    </datalist>
</form>
```

20. **Validação de Formulário Completo:**
```html
<!--Crie um formulário com vários campos e um botão de envio. Escreva um script que valide todos os campos antes de permitir o envio do formulário. -->
<form onsubmit="return validarForm()">
    <!-- Adicione aqui os campos de outros exercícios -->
    <input type="submit" value="Enviar">
</form>

<script>
function validarForm() {
    if (!validarCampoObrigatorio() || !validarEmail() || !validarCheckbox() || !validarRadio() || !validarArquivo()) {
        return false;
    }
    return true;
}
</script>
```
