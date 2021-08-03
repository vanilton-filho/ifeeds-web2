import 'dart:convert';

class ErrorModel {
  final int? statusCode;
  final String? message;

  ErrorModel({
    this.statusCode,
    this.message,
  });

  Map<String, dynamic> toMap() {
    return {
      'statusCode': statusCode,
      'message': message,
    };
  }

  factory ErrorModel.fromMap(Map<String, dynamic> map) {
    return ErrorModel(
      statusCode: map['statusCode'],
      message: map['message'],
    );
  }

  String toJson() => json.encode(toMap());

  factory ErrorModel.fromJson(String source) =>
      ErrorModel.fromMap(json.decode(source));
}
