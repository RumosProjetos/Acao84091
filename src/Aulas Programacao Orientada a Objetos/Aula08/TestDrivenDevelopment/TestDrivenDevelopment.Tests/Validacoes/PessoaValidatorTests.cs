using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrivenDevelopment.BLL.Validacoes;
using TestDrivenDevelopment.DAL.Entidades;

namespace TestDrivenDevelopment.Tests.Validacoes
{
    [TestClass]
    public class PessoaValidatorTests
    {
        [TestMethod]
        public void DeveValidarSexosPermitidosParaFeminino()
        {
            //arrange
            Pessoa p = new Pessoa();
            p.Sexo = "F";
            PessoaValidator validador = new PessoaValidator();

            //act
            bool resultado = validador.ValidarSexo(p);

            //assert 
            Assert.IsTrue(resultado);
        }


        [TestMethod]
        public void DeveValidarSexosPermitidosParaMasculino()
        {
            //arrange
            Pessoa p = new Pessoa();
            p.Sexo = "M";
            PessoaValidator validador = new PessoaValidator();

            //act
            bool resultado = validador.ValidarSexo(p);

            //assert 
            Assert.IsTrue(resultado);
        }


        [TestMethod]
        public void NaoDeveValidarSexosNaoPermitidos()
        {
            //arrange
            Pessoa p = new Pessoa();
            p.Sexo = "Z";
            PessoaValidator validador = new PessoaValidator();

            //act
            bool resultado = validador.ValidarSexo(p);

            //assert 
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void NaoDeveValidarSeNomeMenorQue3Caracteres()
        {
            //arrange
            Pessoa p = new Pessoa();
            p.Nome = "Z";
            PessoaValidator validador = new PessoaValidator();

            //act
            bool resultado = validador.ValidarNome(p);

            //assert 
            Assert.IsFalse(resultado);
        }


        [TestMethod]
        public void NaoDeveValidarSeNomeContiverNumero()
        {
            //arrange
            Pessoa p = new Pessoa();
            p.Nome = "r1 da silva";
            PessoaValidator validador = new PessoaValidator();

            //act
            bool resultado = validador.ValidarNome(p);

            //assert 
            Assert.IsFalse(resultado);
        }
    }
}
