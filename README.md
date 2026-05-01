================================================================
  CIDADE FINANCEIRA VR
  Projeto Final - Meu Primeiro Ambiente VR
  Curso de Realidade Virtual / XR - Fase 1
================================================================

AUTOR
-----
Nome: [Seu Nome Completo]
Turma: [Sua Turma]
Data de Entrega: [Data]

REPOSITÓRIO
-----------
Link do GitHub: https://github.com/[seu-usuario]/cidade-financeira-vr

================================================================
DESCRIÇÃO DO PROJETO
================================================================

A Cidade Financeira VR é uma simulação de ambiente urbano
interativo onde conceitos financeiros do cotidiano são
representados como objetos físicos 3D navegáveis.

O objetivo é tornar visível o que normalmente só existe em
planilhas e extratos bancários — transformando fluxo de caixa,
custos operacionais e geração de renda em objetos que o usuário
pode ver e explorar em Realidade Virtual.

CONCEITO DA CENA:
  Carro       → representa geração de renda (ativo produtivo)
  Posto       → representa custo operacional (despesa recorrente)
  Estrada     → representa o fluxo entre receita e gasto
  Prédios     → representam patrimônio acumulado
  Painel      → exibe o saldo (fluxo de caixa visível)

================================================================
OBJETOS 3D NA CENA (mínimo exigido: 5)
================================================================

  1. Plano de chão (Ground Plane)
     → Terreno principal da cidade, material asfaltado

  2. Carro (Vehicle)
     → Objeto principal — ativo gerador de renda
     → Posicionado na estrada central

  3. Posto de Gasolina (Gas Station)
     → Estrutura com cobertura e bomba
     → Representa custo operacional fixo

  4. Prédio Comercial (Building_01)
     → Representa patrimônio / ativo imobiliário

  5. Painel Financeiro (FinanceBoard)
     → Plano vertical com texto de saldo
     → Posicionado em local visível ao jogador

  6. Árvores / Vegetação (opcional - enriquecimento visual)
     → Assets da Unity Asset Store (gratuitos)

  7. Skybox
     → Configurado com ambiente de cidade diurna

================================================================
CONFIGURAÇÃO TÉCNICA
================================================================

Versão do Unity : [ex: 2022.3.xx LTS]
Render Pipeline : Universal Render Pipeline (URP)
Plataforma      : Android (Meta Quest)
SDK Instalado   : Meta XR SDK [versão]
XR Plugin       : OpenXR / Oculus XR Plugin

MOVIMENTAÇÃO:
  - Controlada pelo teclado no Unity Editor (PC)
  - WASD ou setas para movimentar
  - Mouse para rotacionar câmera
  - Não depende dos óculos para funcionar no Editor

================================================================
ESTRUTURA DE PASTAS (Assets/)
================================================================

  Assets/
  ├── _Scenes/
  │   └── CidadeFinanceira.unity       (cena principal)
  ├── Materials/
  │   ├── MAT_Asfalto
  │   ├── MAT_Predio
  │   └── MAT_Painel
  ├── Prefabs/
  │   ├── PRE_Carro
  │   ├── PRE_Posto
  │   └── PRE_Predio
  ├── Scripts/  (se houver)
  └── Textures/

================================================================
COMO ABRIR O PROJETO
================================================================

  1. Instale o Unity Hub e a versão [X.X.XX LTS]
  2. Clone o repositório:
       git clone https://github.com/[seu-usuario]/cidade-financeira-vr
  3. No Unity Hub, clique em "Add" e selecione a pasta clonada
  4. Abra o projeto e aguarde a importação dos pacotes
  5. Acesse a cena em: Assets/_Scenes/CidadeFinanceira.unity
  6. Pressione Play para explorar o ambiente

================================================================
DIFICULDADES ENCONTRADAS E SOLUÇÕES
================================================================

  [Descreva aqui os problemas reais que você enfrentou]

  Exemplo:
  - Problema: XR Plugin Management não reconhecia o SDK
    Solução: Reinstalação via Package Manager e reinício do Unity

  - Problema: Objetos sem colisão caíam pelo chão
    Solução: Adicionar componente Box Collider em cada prefab

  - Problema: [...]
    Solução: [...]

================================================================
REFLEXÃO SOBRE O APRENDIZADO
================================================================

  [Escreva 3 a 5 frases com suas palavras — isso vale 20% da nota]

  Exemplo:
  "Durante o desenvolvimento, aprendi que a organização da
  hierarquia no Unity é tão importante quanto o resultado visual.
  O maior desafio foi configurar o Meta XR SDK corretamente.
  A ideia de representar finanças como objetos físicos me fez
  pensar diferente sobre como comunicar informação em VR."

================================================================
PRÓXIMAS EVOLUÇÕES (visão futura do projeto)
================================================================

  - Integração com dados financeiros reais via API
  - Multiplayer: outros usuários como personagens na cidade
  - Compatibilidade total com Meta Quest (build Android)
  - Economia tokenizada com Web3 (Fase futura)

================================================================
