import 'dart:convert';

import 'package:ifeeds_app/models/contato_model.dart';

class UsuarioModel {
  int? id;
  String? matricula;
  String? nome;
  ContatoModel? contato;
  String? role;
  bool? status;
  String? campus;

  UsuarioModel({
    this.id,
    this.matricula,
    this.nome,
    this.contato,
    this.role,
    this.status,
    this.campus,
  });

  Map<String, dynamic> toMap() {
    return {
      'id': id,
      'matricula': matricula,
      'nome': nome,
      'contato': contato?.toMap(),
      'role': role,
      'status': status,
      'campus': campus,
    };
  }

  factory UsuarioModel.fromMap(Map<String, dynamic> map) {
    return UsuarioModel(
      id: map['id'],
      matricula: map['matricula'],
      nome: map['nome'],
      contato: ContatoModel.fromMap(map['contato']),
      role: map['role'],
      status: map['status'],
      campus: map['campus'],
    );
  }

  String toJson() => json.encode(toMap());

  factory UsuarioModel.fromJson(String source) =>
      UsuarioModel.fromMap(json.decode(source));
}
