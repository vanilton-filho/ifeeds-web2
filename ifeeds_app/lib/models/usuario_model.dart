import 'dart:convert';

import 'package:ifeeds_app/models/contato_model.dart';

class UsuarioModel {
  String? matricula;
  String? nome;
  ContatoModel? contato;
  String? role;

  UsuarioModel({
    this.matricula,
    this.nome,
    this.contato,
    this.role,
  });

  Map<String, dynamic> toMap() {
    return {
      'matricula': matricula,
      'nome': nome,
      'contato': contato?.toMap(),
      'role': role,
    };
  }

  factory UsuarioModel.fromMap(Map<String, dynamic> map) {
    return UsuarioModel(
      matricula: map['matricula'],
      nome: map['nome'],
      contato: ContatoModel.fromMap(map['contato']),
      role: map['role'],
    );
  }

  String toJson() => json.encode(toMap());

  factory UsuarioModel.fromJson(String source) =>
      UsuarioModel.fromMap(json.decode(source));
}
