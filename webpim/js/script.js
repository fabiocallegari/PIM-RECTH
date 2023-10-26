// automação e bloqueio de data e hora atual 
function initializeForm() {
  // Bloquear a alteração dos campos de data e hora
  document.getElementById('currentDate').readOnly = true;
  document.getElementById('currentTime').readOnly = true;

  // Função para atualizar os campos de data e hora a cada segundo
  function updateDateTime() {
    var currentDateField = document.getElementById('currentDate');
    var currentTimeField = document.getElementById('currentTime');

    var currentDate = new Date();
    var day = currentDate.getDate().toString().padStart(2, '0');
    var month = (currentDate.getMonth() + 1).toString().padStart(2, '0');
    var year = currentDate.getFullYear();
    var formattedDate = day+ '/' + month + '/' + year;

    var hours = currentDate.getHours().toString().padStart(2, '0');
    var minutes = currentDate.getMinutes().toString().padStart(2, '0');
    var formattedTime = hours + ':' + minutes;

    currentDateField.value = formattedDate;
    currentTimeField.value = formattedTime;
  }

  // Chamar a função de atualização a cada segundo
  updateDateTime();
  setInterval(updateDateTime, 1000);
}

/*
let btn = document.querySelector('#verSenha')
let btnConfirm = document.querySelector('#verConfirmSenha')


let nome = document.querySelector('#nome')
let labelNome = document.querySelector('#labelNome')
let validNome = false

let email = document.querySelector('#email')
let labelEmail = document.querySelector('#labelEmail')
let validEmail = false

let usuario = document.querySelector('#usuario')
let labelUsuario = document.querySelector('#labelUsuario')
let validUsuario = false

let senha = document.querySelector('#senha')
let labelSenha = document.querySelector('#labelSenha')
let validSenha = false

let confirmSenha = document.querySelector('#confirmSenha')
let labelConfirmSenha = document.querySelector('#labelConfirmSenha')
let validConfirmSenha = false

let msgError = document.querySelector('#msgError')
let msgSuccess = document.querySelector('#msgSuccess')

nome.addEventListener('keyup', () => {
  if(nome.value.length <= 2){
    labelNome.setAttribute('style', 'color: red')
    labelNome.innerHTML = 'Nome *Insira no minimo 3 caracteres'
    nome.setAttribute('style', 'border-color: red')
    validNome = false
  } else {
    labelNome.setAttribute('style', 'color: green')
    labelNome.innerHTML = 'Nome'
    nome.setAttribute('style', 'border-color: green')
    validNome = true
  }
})

email.addEventListener('keyup', () => {
  if(email.value.length <= 2){
    labelEmail.setAttribute('style', 'color: red')
    labelEmail.innerHTML = 'Email *Insira no minimo 3 caracteres'
    email.setAttribute('style', 'border-color: red')
    validEmail = false
  } else {
    labelEmail.setAttribute('style', 'color: green')
    labelEmail.innerHTML = 'Email'
    email.setAttribute('style', 'border-color: green')
    validEmail = true
  }
})

usuario.addEventListener('keyup', () => {
  if(usuario.value.length <= 4){
    labelUsuario.setAttribute('style', 'color: red')
    labelUsuario.innerHTML = 'Usuário *Insira no minimo 5 caracteres'
    usuario.setAttribute('style', 'border-color: red')
    validUsuario = false
  } else {
    labelUsuario.setAttribute('style', 'color: green')
    labelUsuario.innerHTML = 'Usuário'
    usuario.setAttribute('style', 'border-color: green')
    validUsuario = true
  }
})

senha.addEventListener('keyup', () => {
  if(senha.value.length <= 5){
    labelSenha.setAttribute('style', 'color: red')
    labelSenha.innerHTML = 'Senha *Insira no minimo 6 caracteres'
    senha.setAttribute('style', 'border-color: red')
    validSenha = false
  } else {
    labelSenha.setAttribute('style', 'color: green')
    labelSenha.innerHTML = 'Senha'
    senha.setAttribute('style', 'border-color: green')
    validSenha = true
  }
})

confirmSenha.addEventListener('keyup', () => {
  if(senha.value != confirmSenha.value){
    labelConfirmSenha.setAttribute('style', 'color: red')
    labelConfirmSenha.innerHTML = 'Confirmar Senha *As senhas não conferem'
    confirmSenha.setAttribute('style', 'border-color: red')
    validConfirmSenha = false
  } else {
    labelConfirmSenha.setAttribute('style', 'color: green')
    labelConfirmSenha.innerHTML = 'Confirmar Senha'
    confirmSenha.setAttribute('style', 'border-color: green')
    validConfirmSenha = true
  }
})

/*
function enviarDadosFormulario(){
  if(validNome && validUsuario && validEmail && validSenha && validConfirmSenha){
    let listaUser = JSON.parse(localhost.getItem('listaUser') || '[]')
    
    listaUser.push(
    {
      nomeCad: nome.value,
      userCad: usuario.value,
      senhaCad: senha.value,
      emailCad: email.value,
    }
    )

    msgSuccess.setAttribute('style', 'display: block')
    msgSuccess.innerHTML = '<strong>Cadastrando usuário...</strong>'
    msgError.setAttribute('style', 'display: none')
    msgError.innerHTML = ''
    
    setTimeout(()=>{
        window.location.href = 'http://127.0.0.1:5500/webpim/index.html'
    }, 3000) 
  
    
  } else {
    msgError.setAttribute('style', 'display: block')
    msgError.innerHTML = '<strong>Preencha todos os campos corretamente antes de cadastrar</strong>'
    msgSuccess.innerHTML = ''
    msgSuccess.setAttribute('style', 'display: none')
  }
}

btn.addEventListener('click', ()=>{
  let inputSenha = document.querySelector('#senha')
  
  if(inputSenha.getAttribute('type') == 'password'){
    inputSenha.setAttribute('type', 'text')
  } else {
    inputSenha.setAttribute('type', 'password')
  }
})

btnConfirm.addEventListener('click', ()=>{
  let inputConfirmSenha = document.querySelector('#confirmSenha')
  
  if(inputConfirmSenha.getAttribute('type') == 'password'){
    inputConfirmSenha.setAttribute('type', 'text')
  } else {
    inputConfirmSenha.setAttribute('type', 'password')
  }
})


document.getElementById('cadastroForm').addEventListener('submit', async (event) => {
  event.preventDefault();

  const nome = document.getElementById('nome').value;
  const email = document.getElementById('email').value;
  const usuario = document.getElementById('usuario').value;
  const senha = document.getElementById('senha').value;
  const confirmSenha = document.getElementById('confirmSenha').value;

  // Validação dos campos
  if (!nome || !email || !usuario || !senha || !confirmSenha) {
    document.getElementById('msgError').textContent = 'Preencha todos os campos';
    return;
  } else if (senha !== confirmSenha) {
    document.getElementById('msgError').textContent = 'As senhas não coincidem';
    return;
  } else {
    document.getElementById('msgError').textContent = '';
  }

  // Dados do formulário válidos, faça a solicitação para o servidor
  const response = await fetch('/cadastro', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify({ nome, email, usuario, senha }),
  });

  if (response.ok) {
    const data = await response.json();
    document.getElementById('msgSuccess').textContent = data.message;
    // Limpe os campos do formulário se necessário
  } else {
    const error = await response.json();
    document.getElementById('msgError').textContent = error.error;
  }
});

document.getElementById('formCadastro').addEventListener('submit', (e) => {
  e.preventDefault(); // Impede o envio padrão do formulário

  const nome = document.getElementById('nome').value;
  const email = document.getElementById('email').value;
  const usuario = document.getElementById('usuario').value;
  const senha = document.getElementById('senha').value;
  const confirmSenha = document.getElementById('confirmSenha').value;

  if (senha !== confirmSenha) {
      // Lide com a validação do formulário aqui
      alert("As senhas não correspondem");
      return;
  }
});/*

  // Dados do formulário
  const formData = {
      nome: nome,
      email: email,
      usuario: usuario,
      senha: senha
  };

  fetch('/seu-endpoint-no-servidor', {
      method: 'POST',
      body: JSON.stringify(formData),
      headers: {
          'Content-Type': 'application/json'
      }
  })
  .then(response => response.json())
  .then(data => {
      // Lide com a resposta do servidor aqui
      console.log(data);
      // Redirecione o usuário ou mostre uma mensagem de sucesso
  })
  .catch(error => {
      console.error('Erro ao enviar os dados para o servidor:', error);
  });
});

*/
document.addEventListener('DOMContentLoaded', function () {
  const form = document.querySelector('form');
  const successMessage = document.createElement('p');
  successMessage.style.color = '#27ae60'; /* Cor verde */
  successMessage.style.fontWeight = 'bold';
  successMessage.style.marginTop = '10px';
  successMessage.style.display = 'none';

  form.addEventListener('submit', function (event) {
      event.preventDefault(); // Impede o envio do formulário padrão
      // Simula um envio assíncrono (pode ser substituído pelo código de envio real)
      setTimeout(function () {
          successMessage.textContent = 'Ponto cadastrado com sucesso!';
          successMessage.style.display = 'block';
          form.reset(); // Limpa o formulário após o sucesso
      }, 1000); // Tempo de simulação de envio assíncrono (1 segundo)
  });

  form.appendChild(successMessage);
});

