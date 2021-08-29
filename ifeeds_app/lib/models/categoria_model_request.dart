import 'dart:convert';

class CategoriaModelRequest {
  
  String? nome;
 
 
  CategoriaModelRequest({
    this.nome,
  });

  Map<String, dynamic> toMap() {
    return {
      'nome': nome,
    };
  }

  factory CategoriaModelRequest.fromMap(Map<String, dynamic> map) {
    return CategoriaModelRequest(
      nome: map['nome'],
    );
  }

  String toJson() => json.encode(toMap());

  factory CategoriaModelRequest.fromJson(String source) => CategoriaModelRequest.fromMap(json.decode(source));
}
