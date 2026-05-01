# Projeto: Cidade Financeira VR

## Autor
Armando Freire

---

## Visão Geral

Cidade Financeira VR é uma experiência interativa desenvolvida na Unity que transforma conceitos financeiros do cotidiano em objetos visuais dentro de uma cidade virtual.

O objetivo do projeto é representar entradas, saídas, patrimônio e decisões financeiras por meio de interação direta com elementos 3D do cenário.

---

## Conceito Principal

No ambiente virtual, cada objeto possui significado econômico:

- **Carro** = geração de receita  
- **Posto** = despesas operacionais  
- **Cidade** = evolução patrimonial  
- **Saldo** = resultado financeiro atual

O usuário aprende e administra recursos de forma visual, prática e intuitiva.

---

## Funcionamento Atual

### Receita

Ao clicar no carro, o usuário registra valores recebidos, como:

- corridas por aplicativo  
- entregas  
- trabalhos autônomos  
- serviços prestados

### Despesa

Ao clicar no posto, o usuário registra gastos como:

- combustível  
- manutenção  
- alimentação  
- contas gerais

### Regra Financeira

O saldo nunca pode ficar abaixo de zero.

### Fórmula Base


Saldo = Receitas - Despesas

# Fase 2 — Rede Financeira Web3 Integrada

O projeto poderá evoluir para uma infraestrutura financeira descentralizada, onde pessoas e instituições interagem dentro de uma rede conectada, porém segmentada por permissões.

## Conceito Central

Cada participante visualiza apenas as relações financeiras que lhe pertencem.

### Exemplo

- cliente vê seu saldo  
- cliente vê quem lhe deve  
- cliente vê para quem deve  
- banco vê somente contas autorizadas  
- terceiros não acessam dados privados  

---

## Modelo de Relações

A rede pode permitir:

### Cliente ↔ Banco

- conta digital  
- saldo  
- histórico  
- crédito  

### Cliente ↔ Cliente

- empréstimos pessoais  
- cobranças  
- pagamentos  
- divisão de despesas  

### Cliente ↔ Amigos / Família

- valores pendentes  
- ajuda financeira  
- acordos privados  

### Cliente ↔ Negócios

- compras  
- prestação de serviços  
- renda adicional  

---

## Privacidade Inteligente

Diferente de redes públicas abertas, o sistema poderá funcionar com acesso segmentado.

Cada usuário acessa apenas:

- seus dados  
- suas dívidas  
- seus recebimentos  
- contratos onde participa  

---

## Benefícios da Camada Web3

- propriedade digital real de ativos  
- histórico validado  
- transparência auditável  
- autonomia do usuário  
- interoperabilidade futura  
- economia peer-to-peer  
- reputação financeira digital  

---

## Aplicação no Ambiente Unity

A cidade virtual pode representar em tempo real:

- crescimento patrimonial  
- dívidas pendentes  
- evolução de renda  
- relações econômicas ativas  
- expansão da cidade conforme saldo

# Configuração Técnica do Projeto

O projeto foi desenvolvido na **Unity 6**, utilizando ambiente compatível com experiências XR e preparado para futura integração com dispositivos Meta Quest.

## Estrutura Técnica Implementada

### Engine Utilizada

- Unity 6 (LTS)
- Projeto configurado em ambiente 3D

### Plataforma de Destino

- Windows (testes no editor)
- Android / Meta Quest (estrutura preparada)

### XR / VR

- XR Plugin Management adicionado ao projeto
- Pacotes OpenXR instalados
- Estrutura inicial para integração com Meta XR SDK
- Projeto funcional também no PC, permitindo testes sem headset VR

### Build Settings

Configuração preparada para exportação futura em:

- Android
- Windows Standalone

### Cena Principal Desenvolvida

Ambiente virtual urbano contendo:

- veículo principal (Car9)
- posto de combustível
- prédios
- ruas
- semáforos
- postes
- elementos decorativos

Atendendo o requisito mínimo de múltiplos objetos 3D na cena.

### Sistema de Interação

Foi implementado sistema de interação por clique utilizando C#:

#### Carro

Representa geração de receita.

Ao clicar no carro, o usuário acessa painel para registrar entradas financeiras.

#### Posto

Representa despesas.

Ao clicar no posto, o usuário acessa painel para registrar gastos.

### Interface Gráfica

Desenvolvida com Canvas UI contendo:

- painéis de receita
- painéis de despesa
- campo de entrada de valores
- botões de confirmação
- exibição de saldo

### Lógica Financeira

Sistema programado em C# com regras:

```text
Saldo = Receitas - Despesas
