const objs = [
    {
    nome: "Matheus",
    idade: 30,
    esta_trabalhando: true,
    detalhes_profissao: {
        Profissao: "Programador",
        Empresa: "Empresa X"
    },
    hobbies: ["Programador", "Correr", "Ler"]
},
{
    nome: "João",
    idade: 25,
    esta_trabalhando: true,
    detalhes_profissao: {
        Profissao: null,
        Empresa: null
    },
    hobbies: ["Jogar", "Academia"]
}
];


// JSON
// Converter objetos para json
const jsonData = JSON.stringify(objs);

console.log(jsonData);
console.log(typeof jsonData);

// Converter json para objeto
const objData = JSON.parse(jsonData);
console.log(objData);
console.log(typeof objData);

// Função
objData.map((pessoa) => {
    console.log(pessoa.nome)
})