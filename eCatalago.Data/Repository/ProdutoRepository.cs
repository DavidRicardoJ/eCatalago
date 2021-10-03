﻿using eCatalogo.Core.Models;
using eCatalogo.UseCases.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCatalago.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private List<Produto> produtos;

        public ProdutoRepository()
        {
            produtos = new List<Produto>
            {
                new Produto { ProdutoId = 495, Categoria = "Cosméticos", Nome = "MacBeauty Condicionador de Cabelo KPRO 165 g", Preco = 14.99m, ImagemUrl = "https://d3t32hsnjxo7q6.cloudfront.net/i/991799d3e70b8856686979f8ff6dcfe0_ra,w158,h184_pa,w158,h184.png", Descricao = "Cuidados intensivos para cabelos coloridos, ressecados e/ou danificados. A alta concentração de Extrato de Caviar, o mais poderoso antioxidante, associado à Queratina Hidrolisada e Ácidos Graxos essenciais, para prevenir contra o desbotamento da cor e restaurar a estrutura dos cabelos ressecados ou sensibilizados.  Proteção intensa da cor e hidratação profunda. Restauração dos fios. Cores mais vibrantes e com maior durabilidade. Controle do volume e do frizz. Cabelos desembaraçados, soltos, macios e brilhantes. Proteção solar."},
                new Produto { ProdutoId = 488, Categoria = "Cosméticos", Nome = "MacBeauty Fit Me Bronzer", Preco = 10.29m, ImagemUrl = "https://d3t32hsnjxo7q6.cloudfront.net/i/d4f7d82b4858c622bb3c1cef07b9d850_ra,w158,h184_pa,w158,h184.png", Descricao = "Por que você vai adorar Pigmentos leves se misturam facilmente e se desgastam uniformemente. Oferece uma cor bronzeada natural, à prova de desbotamento, que deixa a pele do jeito que deveria ser ... fresca, respirável e natural Para melhores resultados: para uma aparência suave e natural, escovar ao longo da bochecha, varrendo para cima."},
                new Produto { ProdutoId = 477, Categoria = "Cosméticos", Nome = "MacBeauty Extreme Strength Builder plus máscara - 500ml", Preco = 15.99m, ImagemUrl = "https://d3t32hsnjxo7q6.cloudfront.net/i/4f731de249cbd4cb819ea7f5f4cfb5c3_ra,w158,h184_pa,w158,h184.png", Descricao = "Máscara de tratamento intensivo para cabelos extremamente danificados. Redken Extreme Strength Builder Plus proporciona força, condicionamento e reparação intensa aos fios. Redken Extreme Strength Builder Plus aumenta a resistência do cabelo que sofreu danos severos, para que fiquem até 96% mais fortes já após três aplicações. Agente emoliente que desembaraça os fios enquanto proporciona maleabilidade, hidratação e brilho. Além disso, combate o estresse capilar decorrente de processos químicos. Interlock Protein Network: Fortalece a estrutura capilar interna e reduz a quebra frequente dos fios."},
                new Produto { ProdutoId = 468, Categoria = "Cosméticos", Nome = "MacBeauty Face Studio Master Hi-Light Light Booster Blush", Preco = 14.99m, ImagemUrl = "https://d3t32hsnjxo7q6.cloudfront.net/i/4621032a92cb428ad640c105b944b39c_ra,w158,h184_pa,w158,h184.png", Descricao = "MacBeauty  oferece nutrição intensiva enquanto você dorme para que quando acordar, seus fios estejam macios, suaves e fáceis de pentear. Ideal para qualquer tipo de cabelo seco, não pesa nas estruturas mais finas e ajuda a definir os cachos. O produto Nutritive 8H Magic Night penetra na fibra capilar durante 8 horas para uma alta absorção dos nutrientes perdidos durante a noite. Ele diminui a fricção com o travesseiro, reduz o frizz e deixa um toque sedoso. Tudo isso aliado a uma fragrância relaxante, que te fazer dormir bem. Ação:Extrato de Raiz de Íris: repõe os nutrientes perdidos durante o dia e reveste a fibra capilar. Mistura de 5 Vitaminas: ajuda na absorção dos nutrientes, sela as cutículas e confere um acabamento acetinado."},
                new Produto { ProdutoId = 439, Categoria = "Cosméticos", Nome = "MacBeauty Fit Me Blush", Preco = 10.29m, ImagemUrl = "https://d3t32hsnjxo7q6.cloudfront.net/i/53d5f825461117c0d96946e1029510b0_ra,w158,h184_pa,w158,h184.png", Descricao = "MacBeauty Leave-in para cabelos com frizz. Com ação hidratante, Redken Frizz Dismiss Rebel Tame Leave-in desembaraça, combate o frizz e protege do calor dos acessórios térmicos. O Leave-in Frizz Dismiss Rebel Tame Redken é um creme sem enxágue que oferece vários benefícios para todos os tipos de cabelos indisciplinados. Ele proporciona controle intensivo ao frizz enquanto deixa os fios muito mais sedosos e nutridos, além de mais fáceis de pentear.."},

                new Produto { ProdutoId = 414, Categoria = "Perfumaria", Nome = "MacBeauty Dream Shampoo Night ", Preco = 11.99m, ImagemUrl = "https://d3t32hsnjxo7q6.cloudfront.net/i/51eacb9efebbaee39399e65ffe3d9416_ra,w158,h184_pa,w158,h184.png", Descricao = "Shampoo de nutrição para cabelos normais e ligeiramente secos. Kérastase Nutritive Bain Satin 1 consegued nutrir os fios de maneira eficiente. Além disso, também os mantêm protegidos das agressões físicas, térmicas e mecânicas cotidianas, como por exemplo: escovação, prancha, secador, penteados presos. A nutrição de Kérastase Nutritive Bain Satin 1 recupera a maciez do cabelo desde o banhar, para que ele tenha um toque sedoso, agradável e um movimento bonito, de balanço natural. Seus fios ficam extraordinários: nutridos, macios, protegidos de danos e do ressecamento. Ação: Tecnologia Irisome: combina Gluco-Active e Rizoma de Íris para nutrir de forma profunda e duradoura o cabelo enquanto protege a fibra capilar do ressecamento."},
                new Produto { ProdutoId = 380, Categoria = "Perfumaria", Nome = "MacBeauty Hidratante de Cutículas Stick", Preco = 10.99m, ImagemUrl = "https://d3t32hsnjxo7q6.cloudfront.net/i/d04e7c2ed65dabe1dca4eed9aa268e95_ra,w158,h184_pa,w158,h184.png", Descricao = "Hidratante de cutícula em caneta. Granado SOS Cutículas Perfeitas é prático e fácil de usar, promove a renovação e hidratação imediata das cutículas, além de dar brilho e maciez desde a primeira aplicação. Enriquecido com Óleo de Girassol e Vitamina E, Granado SOS Cutículas Perfeitas tem alto poder nutritivo e hidratante, oferecendo tratamento imediato às unhas e cutículas. Possui textura leve e não altera o brilho ou coloração das unhas esmaltadas. Como usar: Aplique sobre as unhas e cutículas. Massageie até a completa absorção"},
                new Produto { ProdutoId = 379, Categoria = "Perfumaria", Nome = "MacBeauty Dream Matte Mousse Colônia", Preco = 14.79m, ImagemUrl = "https://d3t32hsnjxo7q6.cloudfront.net/i/029889b345c76a70e8bb978b73ed1a87_ra,w158,h184_pa,w158,h184.png", Descricao = "MacBeauty La Nuit Trésor Nude é um perfume Lancôme feminino floral. Uma fragrância intensa, sofisticada e envolvente, como a sensação de uma paixão avassaladora. Sublime e luminosa, apaixona a todos que sentem sua essência. O Perfume Feminino La Nuit Trésor Nude, de Lancôme, é inspirado nas mulheres que não se intimidam em revelar seus desejos. Um aroma sedutor que combina notas de bergamota, coco, baunilha e rosa. Entregue-se para esta fusão deslumbrante! "},
                new Produto { ProdutoId = 366, Categoria = "Perfumaria", Nome = "MacBeauty Mineral Power Natural ", Preco = 14.99m, ImagemUrl = "https://d3t32hsnjxo7q6.cloudfront.net/i/c77ad2da76259cfd67a9a9432f635bfb_ra,w158,h184_pa,w158,h184.png", Descricao = "Floral é um perfume feminino Jimmy Choo floral. Fragrância suave que representa a beleza, confiança e energia de cada mulher. Perfume Jimmy Choo Floral é ultra feminino e delicado. Um aroma refinado, fresco e radiante que traz notas de frutas frescas, folhas, flores como magnólia e notas leves de madeira almiscarada. O frasco verde claro é inspirado no vidro veneziano de Murano"},
                new Produto { ProdutoId = 354, Categoria = "Perfumaria", Nome = "MacBeauty Dream Velvet Foundation", Preco = 18.49m, ImagemUrl = "https://d3t32hsnjxo7q6.cloudfront.net/i/24517c6c81c92eda31cd32b6327c1298_ra,w158,h184_pa,w158,h184.png", Descricao = "Este MacBeauty Polo Red Rush é um perfume Ralph Lauren masculino aromático frutal. A tradução olfativa da adrenalina que corre nas veias do homem moderno. Uma fragrância fresca e enérgica que irradia disposição ao dia a dia. O perfume Ralph Lauren Polo Red Rush traz acordes de tangerina vermelha, toranja e menta para deixar uma atmosfera cítrica e elétrica no ar. Logo se envolve madeira de cedro para concretizar sua personalidade masculina agradável."},
            };
        }

        public Produto GetProduto(int id)
        {
            return produtos.FirstOrDefault(p => p.ProdutoId == id);
        }

        public IEnumerable<Produto> GetProdutos(string filter = null)
        {
            if (string.IsNullOrEmpty(filter)) return produtos;
            return produtos.Where(x => x.Nome.ToLower().Contains(filter.ToLower()));
        }
    }
}
