# Projeto: Cidade Financeira VR

## Autor

Armando Freire

---

## Descrição Geral

Cidade Financeira VR é uma experiência interativa desenvolvida na Unity com o objetivo de representar situações financeiras do cotidiano por meio de elementos visuais dentro de uma cidade virtual.

O projeto transforma conceitos abstratos como receita, despesa, saldo, patrimônio e obrigações financeiras em uma experiência prática, intuitiva e interativa.

Além de atender aos requisitos técnicos da atividade proposta, o projeto também apresenta visão futura para expansão como ambiente econômico digital inteligente.

---

## Apresentando o Projeto

O ambiente criado representa uma cidade temática no contexto de Metaverso voltada para educação financeira e organização pessoal.

Ao invés de utilizar planilhas tradicionais, o usuário interage diretamente com objetos da cidade para compreender melhor sua realidade financeira.

Exemplos:

- carro representa trabalho e geração de renda
- posto representa gastos operacionais
- cidade representa crescimento patrimonial
- saldo representa situação econômica atual

---

## Contexto e Objetivos

O projeto busca demonstrar como experiências imersivas podem tornar temas complexos mais acessíveis, agradáveis e motivadores.

A proposta parte da ideia de que jogos incentivam pessoas a superar desafios, evoluir fases e buscar recompensas.

Aplicando isso às finanças, o ambiente incentiva o usuário a:

- organizar receitas
- controlar despesas
- quitar obrigações
- construir patrimônio
- melhorar hábitos financeiros
- acompanhar evolução pessoal

O foco principal não é vigiar terceiros, mas fortalecer a própria posição financeira do usuário.

---

## Configuração Técnica

### Engine Utilizada

- Unity 6 LTS

### Plataforma de Teste

- Windows (Unity Editor)

### Plataforma Preparada

- Android (Meta Quest)

### XR / VR

- XR Plugin Management instalado
- OpenXR configurado
- Estrutura preparada para futura integração Meta XR SDK

### Build Settings

Projeto preparado para:

- Windows Standalone
- Android

### Execução Inicial

Toda movimentação e testes funcionam no PC, sem depender exclusivamente de headset VR.

---

## Ambiente Virtual

A cena foi organizada com múltiplos objetos 3D coerentes com ambiente urbano:

- carro principal
- posto de combustível
- ruas
- prédios
- postes
- semáforos
- elementos decorativos

Também foram utilizados:

- plano de chão navegável
- skybox configurado
- distribuição lógica dos objetos

---

## Interação Implementada

O projeto possui interação funcional em C# coerente com o tema escolhido.

### Carro

Ao clicar no carro, o usuário registra receitas obtidas por trabalho diário, como:

- corridas por aplicativo
- entregas
- serviços autônomos

### Posto

Ao clicar no posto, o usuário registra despesas, como:

- combustível
- manutenção
- alimentação
- contas gerais

### Regra Financeira

O sistema impede saldo negativo.

### Fórmula Base

Saldo = Receitas - Despesas

## Interface Gráfica

Foi desenvolvido sistema com Canvas UI contendo:

- painéis interativos
- campos de entrada de valores
- botões de confirmação
- exibição de saldo

---

## Organização do Projeto

Estrutura principal:

- Assets
- Scripts
- Prefabs
- Scenes
- Packages
- ProjectSettings

Foi mantida nomenclatura organizada e separação lógica dos arquivos.

---

## Processo de Criação e Dificuldades

O projeto foi desenvolvido progressivamente, começando pela montagem da cidade e posteriormente adicionando lógica financeira e interação.

### Principais desafios encontrados:

- configurar cliques em objetos 3D
- integrar UI com cenário
- organizar Canvas
- configurar colliders
- ajustar scripts em C#

### Soluções aplicadas:

- uso de Box Collider
- scripts de interação
- testes frequentes no Unity Editor
- ajustes na hierarquia
- correções de componentes

---

## Aprendizados Aplicados

Durante o desenvolvimento foram praticados:

- criação de ambientes 3D
- organização de cenas
- programação em C#
- eventos de clique
- lógica financeira básica
- integração UI + objetos 3D
- resolução de problemas técnicos

---

# Expansão Futura / Visão do Projeto

Além da proposta inicial da atividade, o projeto também foi pensado como base para evolução futura.

## Fase 1 — Simulação Financeira Individual

- receitas
- despesas
- saldo
- controle pessoal

## Fase 2 — Crescimento Patrimonial

- imóveis
- novos veículos
- negócios
- expansão visual da cidade

## Fase 3 — Sistema Social Financeiro

- divisão de despesas
- pagamentos entre usuários
- obrigações pendentes
- relações econômicas privadas

## Fase 4 — Rede Financeira Digital Integrada

Possível evolução para ambiente descentralizado onde cada usuário acessa apenas informações que realmente lhe pertencem.

### Conceito

Mais importante do que acompanhar terceiros é visualizar:

- o que possui
- o que ganhou
- o que gastou
- o que precisa pagar
- como está evoluindo financeiramente

### Benefícios

- privacidade segmentada
- autonomia financeira
- histórico validado
- experiência gamificada
- economia entre usuários
- interoperabilidade futura

---

## Conclusão

Cidade Financeira VR atende aos requisitos técnicos propostos na atividade ao demonstrar criação de ambiente XR inicial, cena temática navegável, organização estrutural e interação funcional.

Além disso, apresenta visão criativa ao transformar educação financeira em experiência interativa, mostrando como ambientes imersivos podem motivar pessoas a superar barreiras financeiras e evoluir economicamente.
