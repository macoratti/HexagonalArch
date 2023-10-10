A arquitetura hexagonal, também conhecida como arquitetura de portas e adaptadores (Ports and Adapters architecture),
é um padrão de arquitetura de software que visa criar sistemas altamente flexíveis e desacoplados, facilitando a manutenção, testabilidade e evolução do código.

Hexagonal Architecture : Características

Portas (Ports): As portas são interfaces que definem como o sistema se comunica com o mundo externo, incluindo interações com usuários, outros sistemas 
e recursos externos. Essas portas representam as entradas e saídas do sistema.

Adaptadores (Adapters): Os adaptadores são componentes que implementam as interfaces definidas nas portas. Eles traduzem as solicitações e respostas 
entre o sistema interno e o mundo externo. Os adaptadores podem incluir interfaces de usuário (UI), adaptadores de banco de dados, adaptadores de API, etc.

Núcleo (Core): O núcleo é onde reside a lógica de negócios do sistema. Ele não está diretamente ligado às portas ou adaptadores e, portanto, pode
permanecer isolado e independente de tecnologias específicas.






