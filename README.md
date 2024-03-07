Programa de teste que implementa um sistema de encriptação e desencriptação utilizando o algoritmo AES (Advanced Encryption Standard) 256 bits em modo CBC (Cipher Block Chaining). O programa permite aos usuários inserir uma senha, que pode ser encriptada e exibida em uma caixa de texto específica. Posteriormente, essa senha encriptada pode ser desencriptada de volta para sua forma original.

Possíveis vulnerabilidades: 
1.	A chave de encriptação é fixa e incorporada diretamente no código-fonte; 
2.	O IV (Initialization Vector) também é fixo, o que pode comprometer a segurança;
