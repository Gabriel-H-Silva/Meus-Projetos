var el = document.querySelector("#text");
var text = "Meu nome é Gabriel Henrique de Oliveira Silva e sou de Campinas - Brasil - SP. Tenho 19 ano. Tenho uma paixão pela programação. Tenho quatro anos de experiencia em programação, principalmente na linguagem C#. Durante esse período, tenho me dedicado intensamente ao meu trabalho como programador. Sou uma pessoa comprometida e sempre em busca de aprendizado contínuo." +
" Uma das coisas que mais me motiva é a oportunidade de aprender constantemente. Tenho facilidade em assimilar novos conceitos e tecnologias, o que me permite me manter atualizado no campo da programação. Além disso, sou uma pessoa tranquila e concentrada, o que me ajuda a enfrentar desafios com calma e foco." + 
" Meu interesse pela programação começou quando eu tinha apenas 14 anos. Naquela época, desenvolvi meu próprio jogo utilizando a linguagem C#. Foi uma experiência incrível que me mostrou o potencial da programação e me inspirou a seguir nessa área." +
" No fim de meu curso técnico, desenvolvi um sistema de controle financeiro, como trabalho final. Até hoje, utilizo esse sistema para gerenciar minhas finanças e outras atividades. Essa experiência me ensinou a importância de criar soluções práticas e eficientes para problemas do dia a dia." + 
" Além disso, aprecio trabalhar em equipe. Acredito que a colaboração é fundamental para o sucesso de qualquer projeto. Gosto de compartilhar conhecimento e aprender com meus colegas, pois acredito que juntos podemos alcançar resultados ainda melhores." + 
" No geral, sou um programador dedicado, apaixonado por aprendizado e comprometido em entregar soluções de qualidade. Estou sempre em busca de novos desafios e oportunidades para expandir minhas habilidades e contribuir para o avanço da área de programação."
var interval = 15;

function showtext(el, text, interval) {
  var char = text.split("").reverse();
  
  var typer = setInterval(function() {
  
    if (!char.length) {
        return clearInterval(typer)
    }
    
    var next = char.pop();
    
    el.innerHTML += next;
    
  }, interval);
  
}
showtext(el, text, interval);