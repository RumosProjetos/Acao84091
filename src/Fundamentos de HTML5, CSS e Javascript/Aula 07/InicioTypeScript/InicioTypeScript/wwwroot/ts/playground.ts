let minhaString3: string = "Olá Mundo";
let numero: number = 1;
let boleano: boolean = false;
let data: Date = new Date(2024, 2, 1);


//Comando aleatório em JavaScript
function MinhaFunction(mensagem) {
    alert(mensagem);
}


let valor01: number = 10;
let valor02: number = 20;
let soma: number = valor01 + valor02;
console.log(`A Soma é ${soma}`);

let minhaLista: number[] = [1, 2, 3];
let minhaListaDeFrutas: string[] = ["maçã", "banana", "uva"];

minhaListaDeFrutas.push("laranja"); //ADiciona

for (var i in minhaListaDeFrutas) {
    console.log(i);
}

minhaListaDeFrutas.pop();//Remove

let minhaTupla: [x: number, y: number, z: number] = [10, 20, 20];


let pessoa: { nome: string, idade: number } = { nome: "Joao", idade: 15 };


function Somar (numero: number, numero2: number) {
    return numero + numero2;
}
