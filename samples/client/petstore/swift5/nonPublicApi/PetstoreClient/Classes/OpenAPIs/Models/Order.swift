//
// Order.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation
#if canImport(AnyCodable)
import AnyCodable
#endif

internal struct Order: Codable, JSONEncodable, Hashable {

    internal enum Status: String, Codable, CaseIterable {
        case placed = "placed"
        case approved = "approved"
        case delivered = "delivered"
    }
    internal var id: Int64?
    internal var petId: Int64?
    internal var quantity: Int?
    internal var shipDate: Date?
    /** Order Status */
    internal var status: Status?
    internal var complete: Bool? = false

    internal init(id: Int64? = nil, petId: Int64? = nil, quantity: Int? = nil, shipDate: Date? = nil, status: Status? = nil, complete: Bool? = false) {
        self.id = id
        self.petId = petId
        self.quantity = quantity
        self.shipDate = shipDate
        self.status = status
        self.complete = complete
    }

    internal enum CodingKeys: String, CodingKey, CaseIterable {
        case id
        case petId
        case quantity
        case shipDate
        case status
        case complete
    }

    // Encodable protocol methods

    internal func encode(to encoder: Encoder) throws {
        var container = encoder.container(keyedBy: CodingKeys.self)
        try container.encodeIfPresent(id, forKey: .id)
        try container.encodeIfPresent(petId, forKey: .petId)
        try container.encodeIfPresent(quantity, forKey: .quantity)
        try container.encodeIfPresent(shipDate, forKey: .shipDate)
        try container.encodeIfPresent(status, forKey: .status)
        try container.encodeIfPresent(complete, forKey: .complete)
    }
}

