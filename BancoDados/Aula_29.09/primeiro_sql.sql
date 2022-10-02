SELECT	id,
		nome,
        datanascimento,
        idade,
        status        
FROM pessoa;

select 
idusuario,
id_pessoa,
login,
senha,
status
from usuario
;

select p.id as id_pessoa,
        u.login,
        u.senha,
		p.nome,	
        p.datanascimento as nascimento,
        p.idade,
        u.status as situacao_pessoa,
        u.status as status_usuario
from pessoa as p
join usuario as u
	on p.id = u.id_pessoa
;