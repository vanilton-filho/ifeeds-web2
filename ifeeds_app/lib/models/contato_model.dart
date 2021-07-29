import 'dart:convert';

class ContatoModel {
  final String? email;
  final String? telefone;

  ContatoModel({
    this.email,
    this.telefone,
  });

  Map<String, dynamic> toMap() {
    return {
      'email': email,
      'telefone': telefone,
    };
  }

  factory ContatoModel.fromMap(Map<String, dynamic> map) {
    return ContatoModel(
      email: map['email'],
      telefone: map['telefone'],
    );
  }

  String toJson() => json.encode(toMap());

  factory ContatoModel.fromJson(String source) =>
      ContatoModel.fromMap(json.decode(source));
}
