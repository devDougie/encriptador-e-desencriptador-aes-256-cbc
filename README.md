<!--- ![Image](https://github.com/user-attachments/assets/dc2c35a0-6862-48e6-aab4-8455eea55102) --->

# 🔐 Encriptador/Desencriptador AES-256-CBC

<div align="center">
  <img src="https://github.com/user-attachments/assets/dc2c35a0-6862-48e6-aab4-8455eea55102">
</div>

## 📋 Descrição:

Aplicativo de demonstração em C# que permite criptografar e descriptografar senhas usando o algoritmo AES (Advanced Encryption Standard) com chave de 256 bits no modo CBC (Cipher Block Chaining).

Através de uma interface gráfica simples (Windows Forms), o usuário pode inserir uma senha, visualizar sua versão criptografada e reverter à forma original com um clique.

---

## 🎯 Principais Características:

- 🛡️ **Segurança com AES-256-CBC:** Implementa o algoritmo de criptografia simétrica AES com chave de 256 bits no modo CBC (Cipher Block Chaining), um padrão robusto e amplamente utilizado.
- 🎓 **Enfoque educacional:** O projeto foi pensado como estudo prático de criptografia, ideal para estudantes e desenvolvedores iniciantes em segurança da informação.
- 🧰 **Implementação direta em C#:** Toda a lógica de criptografia e interface é escrita em C#, utilizando bibliotecas padrão do .NET.
- 💡 **Código simples:** Estrutura limpa e bem organizada, facilitando o entendimento da lógica e a personalização do projeto.
- 🖥️ **Interface com Windows Forms:** Fornece uma GUI básica e funcional para interação com o usuário, sem necessidade de terminal ou linha de comando.
- 📦 **Projeto leve e portátil:** Não utiliza *bibliotecas externas*, sendo fácil de compilar e rodar em qualquer ambiente com .NET Framework compatível.

---

## ⚙️ Funcionalidades:

- Criptografia de texto (senhas) com AES-256-CBC
- Descriptografia de texto criptografado
- Interface gráfica simples e intuitiva (Windows Forms)
- Botão de limpeza para reiniciar os campos

---

## 🚀 Tecnologias Utilizadas:

- 💬 **Linguagem:** C# (.NET Framework)
- 🖥️ **IDE:** Visual Studio Community 2022
- 📚 **Bibliotecas:** 
  - `System.Security.Cryptography` (AES)
  - `System.Windows.Forms` (interface gráfica)

---

## ✅ Requisitos:

- Sistema operacional: Windows 10
- IDE recomendada: Visual Studio Community 2022
- .NET Framework instalado (compatível com Windows Forms)

---

## ⚠️ ATENÇÃO! Limitações de Segurança:

Este projeto é apenas para fins educacionais e **não deve ser utilizado em produção** sem as devidas melhorias de segurança.

- 🔑 **Chave de criptografia fixa:** A chave AES é incorporada diretamente no código-fonte.
- 🧱 **IV (Initialization Vector) fixo:** O IV é uma sequência de zeros, o que compromete a aleatoriedade essencial ao modo CBC.

---

## ▶️💻 Como Executar:

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/devDougie/encriptador-e-desencriptador-aes-256-cbc.git
   ```
   
2. Abra o projeto no Visual Studio:
	- Arquivo → Abrir → Projeto/Solução → selecione o arquivo `.sln`.

3. Compile e execute:
	- Pressione `F5` ou clique em "Iniciar".

4. Use a interface:
   - Insira uma senha no campo de texto.
   - Clique em "Encriptar" para gerar o valor criptografado.
   - Clique em "Desencriptar" para reverter à senha original.
   - Utilize "Limpar" para reiniciar os campos.
