

### Exercícios TypeScript

Aqui estão alguns exemplos de exercícios sobre TypeScript que podem ajudar a praticar e entender melhor os conceitos:

1. **Declaração de Variáveis:**
```typescript
// Exercício 1: Declare duas variáveis, atribua valores a elas e faça a soma.
let a: number = 5;
let b: number = 10;
let soma: number = a + b;
console.log("A soma é:", soma);
```


2. **Tipos de Dados:**
```typescript
// Exercício 2: Declare variáveis com diferentes tipos de dados e imprima seus valores.

let numero: number = 7;
let texto: string = "Olá, mundo!";
let ativo: boolean = true;
let lista: number[] = [1, 2, 3];
let pessoa: { nome: string, idade: number } = { nome: "João", idade: 30 };
let funcao: (a: number, b: number) => number = function(a, b) { return a + b; };
let qualquer: any = "qualquer coisa";
let nulo: null = null;
let indefinido: undefined = undefined;
let uniao: string | number = "texto";
let tipo: "A" | "B" = "A";
let generico: Array<number> = [1, 2, 3];
let tupla: [string, number] = ["João", 30];
let enum: enum Cor { Vermelho, Verde, Azul };
let tipoNulo: string | null = "texto";
```

3. **Funções:**
```typescript
// Exercício 3: Crie uma função que retorne a soma de dois números.
function soma(a: number, b: number): number {
    return a + b;
}
console.log("A soma é:", soma(3, 4));
```

4. **Interfaces:**
```typescript
// Exercício 4: Crie uma interface para representar uma pessoa e imprima suas propriedades.
interface Pessoa {
    nome: string;
    idade: number;
    profissao?: string;
}

let joao: Pessoa = { nome: "João", idade: 30 };

function imprimirPessoa(pessoa: Pessoa) {
    console.log(pessoa.nome + " tem " + pessoa.idade + " anos.");
}
```	

5. **Classes:**
```typescript
// Exercício 5: Crie uma classe para representar um carro e imprima suas propriedades.
class Carro {
    marca: string;
    modelo: string;
    ano: number;

    constructor(marca: string, modelo: string, ano: number) {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
    }

    descricao(): string {
        return this.marca + " " + this.modelo + " " + this.ano;
    }
}

let meuCarro = new Carro("Toyota", "Corolla", 2020);

console.log(meuCarro.descricao());
```

5.1 **Implementação de interfaces:**
```typescript
// Exercício 5.1. Crie uma classe que implemente uma interface.

interface Dog {
    id?: number;
    name: string;
    age: number;
    description: string;
}

class DogRecord implements Dog {
    id: number;
    name: string;
    age: number;
    description: string;

    constructor({name, age, description, id = 0}: Dog) {
        this.id = id;
        this.name = name;
        this.age = age;
        this.description = description;
    }

    static load(id: number): DogRecord {
        // code to load dog from database
        return dog;
    }

    save() {
        // code to save dog to database
    }
}

let dog = new DogRecord({name: "Fido", age: 3, description: "A friendly dog"});
```

5.2 **Herança:**
```typescript
// Exercício 5.2. Crie uma classe que herde de outra classe.

class Animal {
    nome: string;

    constructor(nome: string) {
        this.nome = nome;
    }

    fazerBarulho(): void {
        console.log("Barulho de animal");
    }
}

class Cachorro extends Animal {
    fazerBarulho(): void {
        console.log("Au au!");
    }
}

let cachorro = new Cachorro("Rex");

cachorro.fazerBarulho();
```

5.3 **Métodos Estáticos:**
```typescript
// Exercício 5.3. Crie um método estático em uma classe.

class Matematica {
    static somar(a: number, b: number): number {
        return a + b;
    }
}

console.log(Matematica.somar(3, 4));
```

5.4 **Métodos Get e Set:**
```typescript
// Exercício 5.4. Crie métodos get e set em uma classe.

class Pessoa {
    private _nome: string;

    get nome(): string {
        return this._nome;
    }

    set nome(nome: string) {
        this._nome = nome;
    }
}

let pessoa = new Pessoa();

pessoa.nome = "João";

console.log(pessoa.nome);
```


5.5 **Métodos Abstratos:**
```typescript

// Exercício 5.5. Crie um método abstrato em uma classe.

abstract class Animal {
    abstract fazerBarulho(): void;
}

class Cachorro extends Animal {
    fazerBarulho(): void {
        console.log("Au au!");
    }
}

let cachorro = new Cachorro();

cachorro.fazerBarulho();
```


5.6 **Métodos de Classe:**
```typescript

// Exercício 5.6. Crie um método de classe em uma classe.


class Matematica {
    static somar(a: number, b: number): number {
        return a + b;
    }
}

console.log(Matematica.somar(3, 4));
```

5.7 **Métodos de Instância:**
```typescript

// Exercício 5.7. Crie um método de instância em uma classe.

class Pessoa {
    nome: string;

    constructor(nome: string) {
        this.nome = nome;
    }

    apresentar(): void {
        console.log("Olá, meu nome é " + this.nome);
    }
}

let pessoa = new Pessoa("João");
pessoa.apresentar();
```




6. **Módulos:**
```typescript
// Exercício 6: Crie um módulo com uma função e importe-a em outro arquivo.
// arquivo1.ts
export function mensagem(): string {
    return "Olá, mundo!";
}

// arquivo2.ts
import { mensagem } from "./arquivo1";
console.log(mensagem());
```

7. **Generics:**
```typescript
// Exercício 7: Crie uma função genérica que retorne o primeiro elemento de um array.
function primeiroElemento<T>(array: T[]): T {
    return array[0];
}

let numeros: number[] = [1, 2, 3];
let primeiroNumero: number = primeiroElemento(numeros);

let frutas: string[] = ["maçã", "banana", "laranja"];

let primeiraFruta: string = primeiroElemento(frutas);


function identity<T, U> (value: T, message: U) : T {
    console.log(message);
    return value
}


let returnNumber = identity<number, string>(100, 'Hello!');
let returnString = identity<string, string>('100', 'Hola!');
let returnBoolean = identity<boolean, string>(true, 'Bonjour!');

returnNumber = returnNumber * 100;   // OK
returnString = returnString * 100;   // Error: Type 'number' not assignable to type 'string'
returnBoolean = returnBoolean * 100; // Error: Type 'number' not assignable to type 'boolean'
```

8. **Decorators:**
```typescript
// Exercício 8: Crie um decorator para registrar a data e hora de execução de uma função.
function registrarExecucao(target: any, propertyKey: string, descriptor: PropertyDescriptor) {
    let metodoOriginal = descriptor.value;
    descriptor.value = function(...args: any[]) {
        console.log("Método executado em:", new Date());
        return metodoOriginal.apply(this, args);
    };
}

class MinhaClasse {
    @registrarExecucao
    minhaFuncao() {
        console.log("Função executada!");
    }
}

let instancia = new MinhaClasse();
instancia.minhaFuncao();
```

9. **Promises:**
```typescript
// Exercício 9: Crie uma função que retorne uma Promise e use async/await para lidar com o resultado.
function aguardarTempo(tempo: number): Promise<void> {
    return new Promise(resolve => {
        setTimeout(resolve, tempo);
    });
}

async function executar() {
    console.log("Início");
    await aguardarTempo(2000);
    console.log("Fim");
}

executar();
```

10. **Type Guards:**
```typescript
// Exercício 10: Crie uma função que verifica se um valor é um número e use um type guard para lidar com o resultado.
function eNumero(valor: any): valor is number {
    return typeof valor === "number";
}

function dobrar(valor: any): number {
    if (eNumero(valor)) {
        return valor * 2;
    }
    return 0;
}

console.log(dobrar(5));
console.log(dobrar("texto"));
```

11. **Namespaces:**
```typescript
// Exercício 11: Crie um namespace com uma classe e use um alias para importá-la em outro arquivo.

// arquivo1.ts
namespace MeuNamespace {
    export class MinhaClasse {
        mensagem(): string {
            return "Olá, mundo!";
        }
    }
}

// arquivo2.ts
import { MinhaClasse as Classe } from "./arquivo1";

let instancia = new Classe();
console.log(instancia.mensagem());
```
