SELECT     Tipos.T_nome, Funcionario.FUNC_nome
FROM         Departamento INNER JOIN
                      F_D ON Departamento.DEP_id = F_D.F_D_DEP_id INNER JOIN
                      Fluxo ON F_D.F_D_F_id = Fluxo.F_id INNER JOIN
                      Funcionario ON Departamento.DEP_FUNC_id = Funcionario.FUNC_id AND Departamento.DEP_id = Funcionario.FUNC_DEP_id INNER JOIN
                      T_D ON Fluxo.F_T_D_id = T_D.T_D_id INNER JOIN
                      Tipos ON T_D.T_D_T_id = Tipos.T_id